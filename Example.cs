using LLDB;
using Mono.Debugging.Client;
using Mono.Debugging.Soft;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace LLDBSharp
{
	public class Program
	{
		static SoftDebuggerSession session;

		static void ConnectSdb()
		{
			session = new SoftDebuggerSession ();

			var address = IPAddress.Parse("127.0.0.1");
			var port = 12345;

			var args = new SoftDebuggerConnectArgs (string.Empty, address, port)
			{
				MaxConnectionAttempts = 10,
				TimeBetweenConnectionAttempts = 1
			};

			var options = new DebuggerSessionOptions ();

			session.Run(new SoftDebuggerStartInfo(args), options);
		}

		static void Main(string[] args)
		{
			var xcodePath = CppSharp.XcodeToolchain.GetXcodePath();
			var debugServerPath = Path.Combine(xcodePath,
				"Contents/SharedFrameworks/LLDB.framework/Versions/Current/Resources/debugserver");

			Environment.SetEnvironmentVariable("LLDB_DEBUGSERVER_PATH", debugServerPath);

			LLDB.Debugger.Initialize ();

			var debugger = LLDB.Debugger.Create ();
			debugger.Async = false;

			var exe = "mono";
			var exeArgs = new List<string> {
				"--debug",
				"--debugger-agent=transport=dt_socket,address=0.0.0.0:12345,server=y",
				"Managed.exe",
			};

			var sdb = new System.Threading.Thread(ConnectSdb);
			sdb.Start ();

			Console.WriteLine ("Creating a target for {0}", exe);
			var target = debugger.CreateTarget(exe);

			if (target == null)
				throw new Exception ("Could not create LLDB target");

			var mainBreakpoint = target.BreakpointCreateByName ("NativeFunc", null);

			var currentDir = Directory.GetCurrentDirectory ();
			var error = new LLDB.Error();

			LLDB.Process process;

			var stringArgs = exeArgs.Select((string arg) => Marshal.StringToHGlobalAuto (arg)).ToList();
			stringArgs.Add (IntPtr.Zero);

			var stringArgsArr = stringArgs.ToArray ();
			unsafe {
				fixed (IntPtr* ptr = stringArgsArr) {
					process = target.Launch (debugger.GetListener (), (sbyte**)ptr, null, null, null, null,
						currentDir, 0, false, error);
				}
			}

			foreach (var arg in stringArgs)
				Marshal.FreeHGlobal (arg);

			if (process == null || error.ErrorCode != 0)
				throw new Exception (string.Format("Could not create LLDB process: {0}", error.CString));

			var state = process.State;
			Console.WriteLine ("Process state: {0}", state.ToString());

			Console.WriteLine ("Stack trace:");

			for (uint threadIndex = 0; threadIndex < process.NumThreads; ++threadIndex) {
				var thread = process.GetThreadAtIndex (threadIndex);
				Console.WriteLine ("\nThread #{0}:", threadIndex);
					
				for (uint frameIndex = 0; frameIndex < thread.NumFrames; ++frameIndex) {
					var frame = thread.GetFrameAtIndex (frameIndex);
					var function = frame.GetFunction ();
					var symbol = frame.GetSymbol ();

					var pc = frame.GetPCAddress ();
					var addr = pc.GetLoadAddress (target);
					var expr = string.Format ("(char*)mono_pmip((void*){0})", addr);
					var value = frame.EvaluateExpression (expr);

					string frameName = null;
					if (value.IsValid () && value.GetValueAsUnsigned (0) != 0)
						error = ReadCStringFromValue (value, ref frameName);

					var displayName = function.Name ?? symbol.Name ?? frameName ?? "(unknown)";
					Console.WriteLine ("\t{0}", displayName);
				}
			}

			string stdout = string.Empty;
			unsafe {
				var sb = new sbyte [1024];
				fixed (sbyte* ptr = &sb[0]) {
					var ret = process.GetSTDOUT (ptr, (uint)sb.Length);
					if (ret > 0)
						stdout = Marshal.PtrToStringAnsi ((IntPtr)ptr);
				}
			}

			Console.WriteLine ("Stdout: {0}", stdout);

			error = process.Continue ();

			mainBreakpoint.Dispose ();
		}

		static Error ReadCStringFromValue (Value value, ref string @string)
		{
			var error = new Error ();
			if (value.IsValid () && value.GetValueAsUnsigned (0) != 0) {
				var sb = new StringBuilder ();
				uint i = 0;
				while (true) {
					var @char = value.GetPointeeData (i++, 1).GetUnsignedInt8 (error, 0);
					if (error.ErrorCode != 0)
						break;
					if (@char == '\0')
						break;
					sb.Append ((char)@char);
				}
				@string = sb.ToString ();
			}
			return error;
		}
	}
}