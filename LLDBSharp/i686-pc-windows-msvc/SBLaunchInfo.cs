//----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class LaunchInfo : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBLaunchInfo@lldb@@QAE@PAPBD@Z")]
            internal static extern global::System.IntPtr ctor_0(global::System.IntPtr instance, sbyte** argv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBLaunchInfo@lldb@@QAE@ABV01@@Z")]
            internal static extern global::System.IntPtr cctor_1(global::System.IntPtr instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??1SBLaunchInfo@lldb@@QAE@XZ")]
            internal static extern void dtor_0(global::System.IntPtr instance, int delete);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?UserIDIsValid@SBLaunchInfo@lldb@@QAE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool UserIDIsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GroupIDIsValid@SBLaunchInfo@lldb@@QAE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GroupIDIsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetExecutableFile@SBLaunchInfo@lldb@@QAE?AVSBFileSpec@2@XZ")]
            internal static extern void GetExecutableFile_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetExecutableFile@SBLaunchInfo@lldb@@QAEXVSBFileSpec@2@_N@Z")]
            internal static extern void SetExecutableFile_0(global::System.IntPtr instance, LLDB.FileSpec.Internal exe_file, bool add_as_first_arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetListener@SBLaunchInfo@lldb@@QAE?AVSBListener@2@XZ")]
            internal static extern void GetListener_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetArgumentAtIndex@SBLaunchInfo@lldb@@QAEPBDI@Z")]
            internal static extern global::System.IntPtr GetArgumentAtIndex_0(global::System.IntPtr instance, uint idx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetArguments@SBLaunchInfo@lldb@@QAEXPAPBD_N@Z")]
            internal static extern void SetArguments_0(global::System.IntPtr instance, sbyte** argv, bool append);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetEnvironmentEntryAtIndex@SBLaunchInfo@lldb@@QAEPBDI@Z")]
            internal static extern global::System.IntPtr GetEnvironmentEntryAtIndex_0(global::System.IntPtr instance, uint idx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetEnvironmentEntries@SBLaunchInfo@lldb@@QAEXPAPBD_N@Z")]
            internal static extern void SetEnvironmentEntries_0(global::System.IntPtr instance, sbyte** envp, bool append);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?Clear@SBLaunchInfo@lldb@@QAEXXZ")]
            internal static extern void Clear_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?AddCloseFileAction@SBLaunchInfo@lldb@@QAE_NH@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool AddCloseFileAction_0(global::System.IntPtr instance, int fd);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?AddDuplicateFileAction@SBLaunchInfo@lldb@@QAE_NHH@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool AddDuplicateFileAction_0(global::System.IntPtr instance, int fd, int dup_fd);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?AddOpenFileAction@SBLaunchInfo@lldb@@QAE_NHPBD_N1@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool AddOpenFileAction_0(global::System.IntPtr instance, int fd, global::System.IntPtr path, bool read, bool write);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?AddSuppressFileAction@SBLaunchInfo@lldb@@QAE_NH_N0@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool AddSuppressFileAction_0(global::System.IntPtr instance, int fd, bool read, bool write);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetProcessID@SBLaunchInfo@lldb@@QAE_KXZ")]
            internal static extern ulong GetProcessID_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetUserID@SBLaunchInfo@lldb@@QAEIXZ")]
            internal static extern uint GetUserID_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetUserID@SBLaunchInfo@lldb@@QAEXI@Z")]
            internal static extern void SetUserID_0(global::System.IntPtr instance, uint uid);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetGroupID@SBLaunchInfo@lldb@@QAEIXZ")]
            internal static extern uint GetGroupID_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetGroupID@SBLaunchInfo@lldb@@QAEXI@Z")]
            internal static extern void SetGroupID_0(global::System.IntPtr instance, uint gid);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetListener@SBLaunchInfo@lldb@@QAEXAAVSBListener@2@@Z")]
            internal static extern void SetListener_0(global::System.IntPtr instance, global::System.IntPtr listener);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetNumArguments@SBLaunchInfo@lldb@@QAEIXZ")]
            internal static extern uint GetNumArguments_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetNumEnvironmentEntries@SBLaunchInfo@lldb@@QAEIXZ")]
            internal static extern uint GetNumEnvironmentEntries_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetWorkingDirectory@SBLaunchInfo@lldb@@QBEPBDXZ")]
            internal static extern global::System.IntPtr GetWorkingDirectory_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetWorkingDirectory@SBLaunchInfo@lldb@@QAEXPBD@Z")]
            internal static extern void SetWorkingDirectory_0(global::System.IntPtr instance, global::System.IntPtr working_dir);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetLaunchFlags@SBLaunchInfo@lldb@@QAEIXZ")]
            internal static extern uint GetLaunchFlags_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetLaunchFlags@SBLaunchInfo@lldb@@QAEXI@Z")]
            internal static extern void SetLaunchFlags_0(global::System.IntPtr instance, uint flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetProcessPluginName@SBLaunchInfo@lldb@@QAEPBDXZ")]
            internal static extern global::System.IntPtr GetProcessPluginName_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetProcessPluginName@SBLaunchInfo@lldb@@QAEXPBD@Z")]
            internal static extern void SetProcessPluginName_0(global::System.IntPtr instance, global::System.IntPtr plugin_name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetShell@SBLaunchInfo@lldb@@QAEPBDXZ")]
            internal static extern global::System.IntPtr GetShell_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetShell@SBLaunchInfo@lldb@@QAEXPBD@Z")]
            internal static extern void SetShell_0(global::System.IntPtr instance, global::System.IntPtr path);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetShellExpandArguments@SBLaunchInfo@lldb@@QAE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetShellExpandArguments_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetShellExpandArguments@SBLaunchInfo@lldb@@QAEX_N@Z")]
            internal static extern void SetShellExpandArguments_0(global::System.IntPtr instance, bool expand);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetResumeCount@SBLaunchInfo@lldb@@QAEIXZ")]
            internal static extern uint GetResumeCount_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetResumeCount@SBLaunchInfo@lldb@@QAEXI@Z")]
            internal static extern void SetResumeCount_0(global::System.IntPtr instance, uint c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetLaunchEventData@SBLaunchInfo@lldb@@QBEPBDXZ")]
            internal static extern global::System.IntPtr GetLaunchEventData_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetLaunchEventData@SBLaunchInfo@lldb@@QAEXPBD@Z")]
            internal static extern void SetLaunchEventData_0(global::System.IntPtr instance, global::System.IntPtr data);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetDetachOnError@SBLaunchInfo@lldb@@QBE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetDetachOnError_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetDetachOnError@SBLaunchInfo@lldb@@QAEX_N@Z")]
            internal static extern void SetDetachOnError_0(global::System.IntPtr instance, bool enable);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, LaunchInfo> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, LaunchInfo>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static LaunchInfo __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new LaunchInfo(native.ToPointer(), skipVTables);
        }

        public static LaunchInfo __CreateInstance(LaunchInfo.Internal native, bool skipVTables = false)
        {
            return new LaunchInfo(native, skipVTables);
        }

        private static void* __CopyValue(LaunchInfo.Internal native)
        {
            var ret = Marshal.AllocHGlobal(8);
            LLDB.LaunchInfo.Internal.cctor_1(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private LaunchInfo(LaunchInfo.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected LaunchInfo(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public LaunchInfo(sbyte** argv)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            var arg0 = argv;
            Internal.ctor_0((__Instance + __PointerAdjustment), arg0);
        }

        public LaunchInfo(LLDB.LaunchInfo _0)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var arg0 = _0.__Instance;
            Internal.cctor_1((__Instance + __PointerAdjustment), arg0);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        protected virtual void Dispose(bool disposing)
        {
            LLDB.LaunchInfo __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            Internal.dtor_0((__Instance + __PointerAdjustment), 0);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }

        public bool UserIDIsValid()
        {
            var __ret = Internal.UserIDIsValid_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public bool GroupIDIsValid()
        {
            var __ret = Internal.GroupIDIsValid_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public LLDB.FileSpec GetExecutableFile()
        {
            var __ret = new LLDB.FileSpec.Internal();
            Internal.GetExecutableFile_0((__Instance + __PointerAdjustment), new IntPtr(&__ret));
            return LLDB.FileSpec.__CreateInstance(__ret);
        }

        /// <summary>
        /// <para>Set the executable file that will be used to launch the process and</para>
        /// <para>optionally set it as the first argument in the argument vector.</para>
        /// </summary>
        /// <remarks>
        /// <para>This only needs to be specified if clients wish to carefully control</para>
        /// <para>the exact path will be used to launch a binary. If you create a</para>
        /// <para>target with a symlink, that symlink will get resolved in the target</para>
        /// <para>and the resolved path will get used to launch the process. Calling</para>
        /// <para>this function can help you still launch your process using the</para>
        /// <para>path of your choice.</para>
        /// <para>If this function is not called prior to launching with</para>
        /// <para>SBTarget::Launch(...), the target will use the resolved executable</para>
        /// <para>path that was used to create the target.</para>
        /// </remarks>
        /// <param name="exe_file">
        /// <para>The override path to use when launching the executable.</para>
        /// </param>
        /// <param name="add_as_first_arg">
        /// <para>If true, then the path will be inserted into the argument vector</para>
        /// <para>prior to launching. Otherwise the argument vector will be left</para>
        /// <para>alone.</para>
        /// </param>
        public void SetExecutableFile(LLDB.FileSpec exe_file, bool add_as_first_arg)
        {
            var arg0 = ReferenceEquals(exe_file, null) ? new LLDB.FileSpec.Internal() : *(LLDB.FileSpec.Internal*) (exe_file.__Instance);
            Internal.SetExecutableFile_0((__Instance + __PointerAdjustment), arg0, add_as_first_arg);
        }

        /// <summary>
        /// <para>Get the listener that will be used to receive process events.</para>
        /// </summary>
        /// <remarks>
        /// <para>If no listener has been set via a call to</para>
        /// <para>SBLaunchInfo::SetListener(), then an invalid SBListener will be</para>
        /// <para>returned (SBListener::IsValid() will return false). If a listener</para>
        /// <para>has been set, then the valid listener object will be returned.</para>
        /// </remarks>
        public LLDB.Listener GetListener()
        {
            var __ret = new LLDB.Listener.Internal();
            Internal.GetListener_0((__Instance + __PointerAdjustment), new IntPtr(&__ret));
            return LLDB.Listener.__CreateInstance(__ret);
        }

        public string GetArgumentAtIndex(uint idx)
        {
            var __ret = Internal.GetArgumentAtIndex_0((__Instance + __PointerAdjustment), idx);
            return Marshal.PtrToStringAnsi(__ret);
        }

        public void SetArguments(sbyte** argv, bool append)
        {
            var arg0 = argv;
            Internal.SetArguments_0((__Instance + __PointerAdjustment), arg0, append);
        }

        public string GetEnvironmentEntryAtIndex(uint idx)
        {
            var __ret = Internal.GetEnvironmentEntryAtIndex_0((__Instance + __PointerAdjustment), idx);
            return Marshal.PtrToStringAnsi(__ret);
        }

        public void SetEnvironmentEntries(sbyte** envp, bool append)
        {
            var arg0 = envp;
            Internal.SetEnvironmentEntries_0((__Instance + __PointerAdjustment), arg0, append);
        }

        public void Clear()
        {
            Internal.Clear_0((__Instance + __PointerAdjustment));
        }

        public bool AddCloseFileAction(int fd)
        {
            var __ret = Internal.AddCloseFileAction_0((__Instance + __PointerAdjustment), fd);
            return __ret;
        }

        public bool AddDuplicateFileAction(int fd, int dup_fd)
        {
            var __ret = Internal.AddDuplicateFileAction_0((__Instance + __PointerAdjustment), fd, dup_fd);
            return __ret;
        }

        public bool AddOpenFileAction(int fd, string path, bool read, bool write)
        {
            var arg1 = Marshal.StringToHGlobalAnsi(path);
            var __ret = Internal.AddOpenFileAction_0((__Instance + __PointerAdjustment), fd, arg1, read, write);
            Marshal.FreeHGlobal(arg1);
            return __ret;
        }

        public bool AddSuppressFileAction(int fd, bool read, bool write)
        {
            var __ret = Internal.AddSuppressFileAction_0((__Instance + __PointerAdjustment), fd, read, write);
            return __ret;
        }

        public ulong ProcessID
        {
            get
            {
                var __ret = Internal.GetProcessID_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public uint UserID
        {
            get
            {
                var __ret = Internal.GetUserID_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetUserID_0((__Instance + __PointerAdjustment), value);
            }
        }

        public uint GroupID
        {
            get
            {
                var __ret = Internal.GetGroupID_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetGroupID_0((__Instance + __PointerAdjustment), value);
            }
        }

        public LLDB.Listener Listener
        {
            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is a C++ reference (&).");
                var arg0 = value.__Instance;
                Internal.SetListener_0((__Instance + __PointerAdjustment), arg0);
            }
        }

        public uint NumArguments
        {
            get
            {
                var __ret = Internal.GetNumArguments_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public uint NumEnvironmentEntries
        {
            get
            {
                var __ret = Internal.GetNumEnvironmentEntries_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public string WorkingDirectory
        {
            get
            {
                var __ret = Internal.GetWorkingDirectory_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }

            set
            {
                var arg0 = Marshal.StringToHGlobalAnsi(value);
                Internal.SetWorkingDirectory_0((__Instance + __PointerAdjustment), arg0);
                Marshal.FreeHGlobal(arg0);
            }
        }

        public uint LaunchFlags
        {
            get
            {
                var __ret = Internal.GetLaunchFlags_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetLaunchFlags_0((__Instance + __PointerAdjustment), value);
            }
        }

        public string ProcessPluginName
        {
            get
            {
                var __ret = Internal.GetProcessPluginName_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }

            set
            {
                var arg0 = Marshal.StringToHGlobalAnsi(value);
                Internal.SetProcessPluginName_0((__Instance + __PointerAdjustment), arg0);
                Marshal.FreeHGlobal(arg0);
            }
        }

        public string Shell
        {
            get
            {
                var __ret = Internal.GetShell_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }

            set
            {
                var arg0 = Marshal.StringToHGlobalAnsi(value);
                Internal.SetShell_0((__Instance + __PointerAdjustment), arg0);
                Marshal.FreeHGlobal(arg0);
            }
        }

        public bool ShellExpandArguments
        {
            get
            {
                var __ret = Internal.GetShellExpandArguments_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetShellExpandArguments_0((__Instance + __PointerAdjustment), value);
            }
        }

        public uint ResumeCount
        {
            get
            {
                var __ret = Internal.GetResumeCount_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetResumeCount_0((__Instance + __PointerAdjustment), value);
            }
        }

        public string LaunchEventData
        {
            get
            {
                var __ret = Internal.GetLaunchEventData_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }

            set
            {
                var arg0 = Marshal.StringToHGlobalAnsi(value);
                Internal.SetLaunchEventData_0((__Instance + __PointerAdjustment), arg0);
                Marshal.FreeHGlobal(arg0);
            }
        }

        public bool DetachOnError
        {
            get
            {
                var __ret = Internal.GetDetachOnError_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetDetachOnError_0((__Instance + __PointerAdjustment), value);
            }
        }
    }
}
