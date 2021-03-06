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
    public unsafe partial class ExecutionContext : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBExecutionContext@lldb@@QAE@XZ")]
            internal static extern global::System.IntPtr ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBExecutionContext@lldb@@QAE@ABV01@@Z")]
            internal static extern global::System.IntPtr cctor_1(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBExecutionContext@lldb@@QAE@ABVSBTarget@1@@Z")]
            internal static extern global::System.IntPtr ctor_3(global::System.IntPtr instance, global::System.IntPtr target);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBExecutionContext@lldb@@QAE@ABVSBProcess@1@@Z")]
            internal static extern global::System.IntPtr ctor_4(global::System.IntPtr instance, global::System.IntPtr process);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBExecutionContext@lldb@@QAE@VSBThread@1@@Z")]
            internal static extern global::System.IntPtr ctor_5(global::System.IntPtr instance, LLDB.Thread.Internal thread);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBExecutionContext@lldb@@QAE@ABVSBFrame@1@@Z")]
            internal static extern global::System.IntPtr ctor_6(global::System.IntPtr instance, global::System.IntPtr frame);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??1SBExecutionContext@lldb@@QAE@XZ")]
            internal static extern void dtor_0(global::System.IntPtr instance, int delete);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetTarget@SBExecutionContext@lldb@@QBE?AVSBTarget@2@XZ")]
            internal static extern void GetTarget_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetProcess@SBExecutionContext@lldb@@QBE?AVSBProcess@2@XZ")]
            internal static extern void GetProcess_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetThread@SBExecutionContext@lldb@@QBE?AVSBThread@2@XZ")]
            internal static extern void GetThread_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetFrame@SBExecutionContext@lldb@@QBE?AVSBFrame@2@XZ")]
            internal static extern void GetFrame_0(global::System.IntPtr instance, global::System.IntPtr @return);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, ExecutionContext> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, ExecutionContext>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static ExecutionContext __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new ExecutionContext(native.ToPointer(), skipVTables);
        }

        public static ExecutionContext __CreateInstance(ExecutionContext.Internal native, bool skipVTables = false)
        {
            return new ExecutionContext(native, skipVTables);
        }

        private static void* __CopyValue(ExecutionContext.Internal native)
        {
            var ret = Marshal.AllocHGlobal(8);
            LLDB.ExecutionContext.Internal.cctor_1(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private ExecutionContext(ExecutionContext.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ExecutionContext(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ExecutionContext()
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public ExecutionContext(LLDB.ExecutionContext rhs)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(rhs, null))
                throw new global::System.ArgumentNullException("rhs", "Cannot be null because it is a C++ reference (&).");
            var arg0 = rhs.__Instance;
            Internal.cctor_1((__Instance + __PointerAdjustment), arg0);
        }

        public ExecutionContext(LLDB.Target target)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(target, null))
                throw new global::System.ArgumentNullException("target", "Cannot be null because it is a C++ reference (&).");
            var arg0 = target.__Instance;
            Internal.ctor_3((__Instance + __PointerAdjustment), arg0);
        }

        public ExecutionContext(LLDB.Process process)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(process, null))
                throw new global::System.ArgumentNullException("process", "Cannot be null because it is a C++ reference (&).");
            var arg0 = process.__Instance;
            Internal.ctor_4((__Instance + __PointerAdjustment), arg0);
        }

        public ExecutionContext(LLDB.Thread thread)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            var arg0 = ReferenceEquals(thread, null) ? new LLDB.Thread.Internal() : *(LLDB.Thread.Internal*) (thread.__Instance);
            Internal.ctor_5((__Instance + __PointerAdjustment), arg0);
        }

        public ExecutionContext(LLDB.Frame frame)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(frame, null))
                throw new global::System.ArgumentNullException("frame", "Cannot be null because it is a C++ reference (&).");
            var arg0 = frame.__Instance;
            Internal.ctor_6((__Instance + __PointerAdjustment), arg0);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        protected virtual void Dispose(bool disposing)
        {
            LLDB.ExecutionContext __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            Internal.dtor_0((__Instance + __PointerAdjustment), 0);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }

        public LLDB.Target GetTarget()
        {
            var __ret = new LLDB.Target.Internal();
            Internal.GetTarget_0((__Instance + __PointerAdjustment), new IntPtr(&__ret));
            return LLDB.Target.__CreateInstance(__ret);
        }

        public LLDB.Process GetProcess()
        {
            var __ret = new LLDB.Process.Internal();
            Internal.GetProcess_0((__Instance + __PointerAdjustment), new IntPtr(&__ret));
            return LLDB.Process.__CreateInstance(__ret);
        }

        public LLDB.Thread GetThread()
        {
            var __ret = new LLDB.Thread.Internal();
            Internal.GetThread_0((__Instance + __PointerAdjustment), new IntPtr(&__ret));
            return LLDB.Thread.__CreateInstance(__ret);
        }

        public LLDB.Frame GetFrame()
        {
            var __ret = new LLDB.Frame.Internal();
            Internal.GetFrame_0((__Instance + __PointerAdjustment), new IntPtr(&__ret));
            return LLDB.Frame.__CreateInstance(__ret);
        }
    }
}
