//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class SymbolContextList : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb19SBSymbolContextListC2Ev")]
            internal static extern void ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb19SBSymbolContextListC2ERKS0_")]
            internal static extern void cctor_1(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb19SBSymbolContextListD2Ev")]
            internal static extern void dtor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb19SBSymbolContextList7IsValidEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb19SBSymbolContextList17GetContextAtIndexEj")]
            internal static extern void GetContextAtIndex_0(global::System.IntPtr @return, global::System.IntPtr instance, uint idx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb19SBSymbolContextList14GetDescriptionERNS_8SBStreamE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetDescription_0(global::System.IntPtr instance, global::System.IntPtr description);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb19SBSymbolContextList6AppendERNS_15SBSymbolContextE")]
            internal static extern void Append_0(global::System.IntPtr instance, global::System.IntPtr sc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb19SBSymbolContextList6AppendERS0_")]
            internal static extern void Append_1(global::System.IntPtr instance, global::System.IntPtr sc_list);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb19SBSymbolContextList5ClearEv")]
            internal static extern void Clear_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb19SBSymbolContextList7GetSizeEv")]
            internal static extern uint GetSize_0(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, SymbolContextList> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, SymbolContextList>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static SymbolContextList __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new SymbolContextList(native.ToPointer(), skipVTables);
        }

        public static SymbolContextList __CreateInstance(SymbolContextList.Internal native, bool skipVTables = false)
        {
            return new SymbolContextList(native, skipVTables);
        }

        private static void* __CopyValue(SymbolContextList.Internal native)
        {
            var ret = Marshal.AllocHGlobal(4);
            LLDB.SymbolContextList.Internal.cctor_1(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private SymbolContextList(SymbolContextList.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected SymbolContextList(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public SymbolContextList()
        {
            __Instance = Marshal.AllocHGlobal(4);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public SymbolContextList(LLDB.SymbolContextList rhs)
        {
            __Instance = Marshal.AllocHGlobal(4);
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
            LLDB.SymbolContextList __dummy;
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

        public LLDB.SymbolContext GetContextAtIndex(uint idx)
        {
            var __ret = new LLDB.SymbolContext.Internal();
            Internal.GetContextAtIndex_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), idx);
            return LLDB.SymbolContext.__CreateInstance(__ret);
        }

        public bool GetDescription(LLDB.Stream description)
        {
            if (ReferenceEquals(description, null))
                throw new global::System.ArgumentNullException("description", "Cannot be null because it is a C++ reference (&).");
            var arg0 = description.__Instance;
            var __ret = Internal.GetDescription_0((__Instance + __PointerAdjustment), arg0);
            return __ret;
        }

        public void Append(LLDB.SymbolContext sc)
        {
            if (ReferenceEquals(sc, null))
                throw new global::System.ArgumentNullException("sc", "Cannot be null because it is a C++ reference (&).");
            var arg0 = sc.__Instance;
            Internal.Append_0((__Instance + __PointerAdjustment), arg0);
        }

        public void Append(LLDB.SymbolContextList sc_list)
        {
            if (ReferenceEquals(sc_list, null))
                throw new global::System.ArgumentNullException("sc_list", "Cannot be null because it is a C++ reference (&).");
            var arg0 = sc_list.__Instance;
            Internal.Append_1((__Instance + __PointerAdjustment), arg0);
        }

        public void Clear()
        {
            Internal.Clear_0((__Instance + __PointerAdjustment));
        }

        public uint Size
        {
            get
            {
                var __ret = Internal.GetSize_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }
    }
}
