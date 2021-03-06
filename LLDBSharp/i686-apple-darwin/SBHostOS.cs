//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class HostOS : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBHostOSC2ERKS0_")]
            internal static extern void cctor_1(global::System.IntPtr instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBHostOS18GetProgramFileSpecEv")]
            internal static extern void GetProgramFileSpec_0(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBHostOS17GetLLDBPythonPathEv")]
            internal static extern void GetLLDBPythonPath_0(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBHostOS11GetLLDBPathENS_8PathTypeE")]
            internal static extern void GetLLDBPath_0(global::System.IntPtr @return, LLDB.PathType path_type);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBHostOS20GetUserHomeDirectoryEv")]
            internal static extern void GetUserHomeDirectory_0(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBHostOS13ThreadCreatedEPKc")]
            internal static extern void ThreadCreated_0(global::System.IntPtr name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBHostOS12ThreadCreateEPKcPFPvS3_ES3_PNS_7SBErrorE")]
            internal static extern global::System.IntPtr ThreadCreate_0(global::System.IntPtr name, global::System.IntPtr thread_function, global::System.IntPtr thread_arg, global::System.IntPtr err);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBHostOS12ThreadCancelEP17_opaque_pthread_tPNS_7SBErrorE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool ThreadCancel_0(global::System.IntPtr thread, global::System.IntPtr err);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBHostOS12ThreadDetachEP17_opaque_pthread_tPNS_7SBErrorE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool ThreadDetach_0(global::System.IntPtr thread, global::System.IntPtr err);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBHostOS10ThreadJoinEP17_opaque_pthread_tPPvPNS_7SBErrorE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool ThreadJoin_0(global::System.IntPtr thread, global::System.IntPtr result, global::System.IntPtr err);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, HostOS> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, HostOS>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static HostOS __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new HostOS(native.ToPointer(), skipVTables);
        }

        public static HostOS __CreateInstance(HostOS.Internal native, bool skipVTables = false)
        {
            return new HostOS(native, skipVTables);
        }

        private static void* __CopyValue(HostOS.Internal native)
        {
            var ret = Marshal.AllocHGlobal(0);
            *(HostOS.Internal*) ret = native;
            return ret.ToPointer();
        }

        private HostOS(HostOS.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected HostOS(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public HostOS()
        {
            __Instance = Marshal.AllocHGlobal(0);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public HostOS(LLDB.HostOS _0)
        {
            __Instance = Marshal.AllocHGlobal(0);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((HostOS.Internal*) __Instance) = *((HostOS.Internal*) _0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        protected virtual void Dispose(bool disposing)
        {
            LLDB.HostOS __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }

        public static LLDB.FileSpec GetProgramFileSpec()
        {
            var __ret = new LLDB.FileSpec.Internal();
            Internal.GetProgramFileSpec_0(new IntPtr(&__ret));
            return LLDB.FileSpec.__CreateInstance(__ret);
        }

        public static LLDB.FileSpec GetLLDBPythonPath()
        {
            var __ret = new LLDB.FileSpec.Internal();
            Internal.GetLLDBPythonPath_0(new IntPtr(&__ret));
            return LLDB.FileSpec.__CreateInstance(__ret);
        }

        public static LLDB.FileSpec GetLLDBPath(LLDB.PathType path_type)
        {
            var arg0 = path_type;
            var __ret = new LLDB.FileSpec.Internal();
            Internal.GetLLDBPath_0(new IntPtr(&__ret), arg0);
            return LLDB.FileSpec.__CreateInstance(__ret);
        }

        public static LLDB.FileSpec GetUserHomeDirectory()
        {
            var __ret = new LLDB.FileSpec.Internal();
            Internal.GetUserHomeDirectory_0(new IntPtr(&__ret));
            return LLDB.FileSpec.__CreateInstance(__ret);
        }

        public static void ThreadCreated(string name)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(name);
            Internal.ThreadCreated_0(arg0);
            Marshal.FreeHGlobal(arg0);
        }

        public static global::System.IntPtr ThreadCreate(string name, LLDB.thread_func_t thread_function, global::System.IntPtr thread_arg, LLDB.Error err)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(name);
            var arg1 = thread_function == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(thread_function);
            var arg2 = thread_arg;
            var arg3 = ReferenceEquals(err, null) ? global::System.IntPtr.Zero : err.__Instance;
            var __ret = Internal.ThreadCreate_0(arg0, arg1, arg2, arg3);
            Marshal.FreeHGlobal(arg0);
            return __ret;
        }

        public static bool ThreadCancel(global::System.IntPtr thread, LLDB.Error err)
        {
            var arg1 = ReferenceEquals(err, null) ? global::System.IntPtr.Zero : err.__Instance;
            var __ret = Internal.ThreadCancel_0(thread, arg1);
            return __ret;
        }

        public static bool ThreadDetach(global::System.IntPtr thread, LLDB.Error err)
        {
            var arg1 = ReferenceEquals(err, null) ? global::System.IntPtr.Zero : err.__Instance;
            var __ret = Internal.ThreadDetach_0(thread, arg1);
            return __ret;
        }

        public static bool ThreadJoin(global::System.IntPtr thread, global::System.IntPtr result, LLDB.Error err)
        {
            var arg1 = result;
            var arg2 = ReferenceEquals(err, null) ? global::System.IntPtr.Zero : err.__Instance;
            var __ret = Internal.ThreadJoin_0(thread, arg1, arg2);
            return __ret;
        }
    }
}
