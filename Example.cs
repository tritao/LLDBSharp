using LLDB;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace LLDBSharp
{
	public class Program
	{
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
				"hello.exe",
			};

			Console.WriteLine ("Creating a target for {0}", exe);
			var target = debugger.CreateTarget(exe);

			if (target == null)
				throw new Exception ("Could not create LLDB target");

			var mainBreakpoint = target.BreakpointCreateByName ("mono_runtime_invoke", target.GetExecutable().Filename);

			var currentDir = Directory.GetCurrentDirectory ();
			var error = new LLDB.Error();

			LLDB.Process process;

			var stringArgs = exeArgs.Select((string arg) => Marshal.StringToHGlobalAuto (arg)).ToList();
			stringArgs.Add (IntPtr.Zero);

			var stringArgsArr = stringArgs.ToArray ();
			unsafe {
				fixed (IntPtr* ptr = stringArgsArr) {
					unsafe
					{
						process = target.Launch(debugger.GetListener(), (sbyte**)ptr, null, null, null, null, currentDir,
							0, false, error);
					}					
				}
			}

			if (process == null || error.ErrorCode != 0)
				throw new Exception (string.Format("Could not create LLDB process: {0}", error.CString));

			var state = process.State;
			Console.WriteLine ("Process state: {0}", state.ToString());

			for (uint threadIndex = 0; threadIndex < process.NumThreads; ++threadIndex) {
				var thread = process.GetThreadAtIndex (threadIndex);

				Console.WriteLine ("Stack trace");
				for (uint frameIndex = 0; frameIndex < thread.NumFrames; ++frameIndex) {
					var frame = thread.GetFrameAtIndex (frameIndex);
					var function = frame.GetFunction ();

					var symbol = frame.GetSymbol ();
					Console.WriteLine ("\t{0}", function.Name != null ?
						function.Name : symbol.Name);
				}
			}

			error = process.Continue ();
		}
	}
}