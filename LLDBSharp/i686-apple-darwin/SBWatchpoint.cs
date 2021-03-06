//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class Watchpoint : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBWatchpointC2Ev")]
            internal static extern void ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBWatchpointC2ERKS0_")]
            internal static extern void cctor_1(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBWatchpointD2Ev")]
            internal static extern void dtor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb12SBWatchpoint7IsValidEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBWatchpoint8GetErrorEv")]
            internal static extern void GetError_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBWatchpoint9IsEnabledEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsEnabled_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBWatchpoint14GetDescriptionERNS_8SBStreamENS_16DescriptionLevelE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetDescription_0(global::System.IntPtr instance, global::System.IntPtr description, LLDB.DescriptionLevel level);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBWatchpoint5ClearEv")]
            internal static extern void Clear_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBWatchpoint22EventIsWatchpointEventERKNS_7SBEventE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool EventIsWatchpointEvent_0(global::System.IntPtr @event);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBWatchpoint31GetWatchpointEventTypeFromEventERKNS_7SBEventE")]
            internal static extern LLDB.WatchpointEventType GetWatchpointEventTypeFromEvent_0(global::System.IntPtr @event);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBWatchpoint22GetWatchpointFromEventERKNS_7SBEventE")]
            internal static extern void GetWatchpointFromEvent_0(global::System.IntPtr @return, global::System.IntPtr @event);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBWatchpoint5GetIDEv")]
            internal static extern int GetID_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBWatchpoint16GetHardwareIndexEv")]
            internal static extern int GetHardwareIndex_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBWatchpoint15GetWatchAddressEv")]
            internal static extern ulong GetWatchAddress_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBWatchpoint12GetWatchSizeEv")]
            internal static extern uint GetWatchSize_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBWatchpoint10SetEnabledEb")]
            internal static extern void SetEnabled_0(global::System.IntPtr instance, bool enabled);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBWatchpoint11GetHitCountEv")]
            internal static extern uint GetHitCount_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBWatchpoint14GetIgnoreCountEv")]
            internal static extern uint GetIgnoreCount_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBWatchpoint14SetIgnoreCountEj")]
            internal static extern void SetIgnoreCount_0(global::System.IntPtr instance, uint n);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBWatchpoint12GetConditionEv")]
            internal static extern global::System.IntPtr GetCondition_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBWatchpoint12SetConditionEPKc")]
            internal static extern void SetCondition_0(global::System.IntPtr instance, global::System.IntPtr condition);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Watchpoint> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Watchpoint>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static Watchpoint __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new Watchpoint(native.ToPointer(), skipVTables);
        }

        public static Watchpoint __CreateInstance(Watchpoint.Internal native, bool skipVTables = false)
        {
            return new Watchpoint(native, skipVTables);
        }

        private static void* __CopyValue(Watchpoint.Internal native)
        {
            var ret = Marshal.AllocHGlobal(8);
            LLDB.Watchpoint.Internal.cctor_1(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private Watchpoint(Watchpoint.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Watchpoint(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Watchpoint()
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public Watchpoint(LLDB.Watchpoint rhs)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(rhs, null))
                throw new global::System.ArgumentNullException("rhs", "Cannot be null because it is a C++ reference (&).");
            var arg0 = rhs.__Instance;
            Internal.cctor_1((__Instance + __PointerAdjustment), arg0);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        protected virtual void Dispose(bool disposing)
        {
            LLDB.Watchpoint __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            Internal.dtor_0((__Instance + __PointerAdjustment));
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }

        public bool IsValid()
        {
            var __ret = Internal.IsValid_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public LLDB.Error GetError()
        {
            var __ret = new LLDB.Error.Internal();
            Internal.GetError_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
            return LLDB.Error.__CreateInstance(__ret);
        }

        public bool IsEnabled()
        {
            var __ret = Internal.IsEnabled_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public bool GetDescription(LLDB.Stream description, LLDB.DescriptionLevel level)
        {
            if (ReferenceEquals(description, null))
                throw new global::System.ArgumentNullException("description", "Cannot be null because it is a C++ reference (&).");
            var arg0 = description.__Instance;
            var arg1 = level;
            var __ret = Internal.GetDescription_0((__Instance + __PointerAdjustment), arg0, arg1);
            return __ret;
        }

        public void Clear()
        {
            Internal.Clear_0((__Instance + __PointerAdjustment));
        }

        public static bool EventIsWatchpointEvent(LLDB.Event @event)
        {
            if (ReferenceEquals(@event, null))
                throw new global::System.ArgumentNullException("@event", "Cannot be null because it is a C++ reference (&).");
            var arg0 = @event.__Instance;
            var __ret = Internal.EventIsWatchpointEvent_0(arg0);
            return __ret;
        }

        public static LLDB.WatchpointEventType GetWatchpointEventTypeFromEvent(LLDB.Event @event)
        {
            if (ReferenceEquals(@event, null))
                throw new global::System.ArgumentNullException("@event", "Cannot be null because it is a C++ reference (&).");
            var arg0 = @event.__Instance;
            var __ret = Internal.GetWatchpointEventTypeFromEvent_0(arg0);
            return __ret;
        }

        public static LLDB.Watchpoint GetWatchpointFromEvent(LLDB.Event @event)
        {
            if (ReferenceEquals(@event, null))
                throw new global::System.ArgumentNullException("@event", "Cannot be null because it is a C++ reference (&).");
            var arg0 = @event.__Instance;
            var __ret = new LLDB.Watchpoint.Internal();
            Internal.GetWatchpointFromEvent_0(new IntPtr(&__ret), arg0);
            return LLDB.Watchpoint.__CreateInstance(__ret);
        }

        public int ID
        {
            get
            {
                var __ret = Internal.GetID_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public int HardwareIndex
        {
            get
            {
                var __ret = Internal.GetHardwareIndex_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public ulong WatchAddress
        {
            get
            {
                var __ret = Internal.GetWatchAddress_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public uint WatchSize
        {
            get
            {
                var __ret = Internal.GetWatchSize_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public bool Enabled
        {
            set
            {
                Internal.SetEnabled_0((__Instance + __PointerAdjustment), value);
            }
        }

        public uint HitCount
        {
            get
            {
                var __ret = Internal.GetHitCount_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public uint IgnoreCount
        {
            get
            {
                var __ret = Internal.GetIgnoreCount_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetIgnoreCount_0((__Instance + __PointerAdjustment), value);
            }
        }

        public string Condition
        {
            get
            {
                var __ret = Internal.GetCondition_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }

            set
            {
                var arg0 = Marshal.StringToHGlobalAnsi(value);
                Internal.SetCondition_0((__Instance + __PointerAdjustment), arg0);
                Marshal.FreeHGlobal(arg0);
            }
        }
    }
}
