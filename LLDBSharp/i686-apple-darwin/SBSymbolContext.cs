//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class SymbolContext : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBSymbolContextC2Ev")]
            internal static extern void ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBSymbolContextC2ERKS0_")]
            internal static extern void cctor_1(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBSymbolContextD2Ev")]
            internal static extern void dtor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb15SBSymbolContext7IsValidEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBSymbolContext9GetModuleEv")]
            internal static extern void GetModule_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBSymbolContext14GetCompileUnitEv")]
            internal static extern void GetCompileUnit_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBSymbolContext11GetFunctionEv")]
            internal static extern void GetFunction_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBSymbolContext8GetBlockEv")]
            internal static extern void GetBlock_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBSymbolContext12GetLineEntryEv")]
            internal static extern void GetLineEntry_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBSymbolContext9GetSymbolEv")]
            internal static extern void GetSymbol_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb15SBSymbolContext23GetParentOfInlinedScopeERKNS_9SBAddressERS1_")]
            internal static extern void GetParentOfInlinedScope_0(global::System.IntPtr @return, global::System.IntPtr instance, global::System.IntPtr curr_frame_pc, global::System.IntPtr parent_frame_addr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBSymbolContext14GetDescriptionERNS_8SBStreamE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetDescription_0(global::System.IntPtr instance, global::System.IntPtr description);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBSymbolContext9SetModuleENS_8SBModuleE")]
            internal static extern void SetModule_0(global::System.IntPtr instance, LLDB.Module.Internal module);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBSymbolContext14SetCompileUnitENS_13SBCompileUnitE")]
            internal static extern void SetCompileUnit_0(global::System.IntPtr instance, LLDB.CompileUnit.Internal compile_unit);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBSymbolContext11SetFunctionENS_10SBFunctionE")]
            internal static extern void SetFunction_0(global::System.IntPtr instance, LLDB.Function.Internal function);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBSymbolContext8SetBlockENS_7SBBlockE")]
            internal static extern void SetBlock_0(global::System.IntPtr instance, LLDB.Block.Internal block);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBSymbolContext12SetLineEntryENS_11SBLineEntryE")]
            internal static extern void SetLineEntry_0(global::System.IntPtr instance, LLDB.LineEntry.Internal line_entry);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBSymbolContext9SetSymbolENS_8SBSymbolE")]
            internal static extern void SetSymbol_0(global::System.IntPtr instance, LLDB.Symbol.Internal symbol);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, SymbolContext> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, SymbolContext>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static SymbolContext __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new SymbolContext(native.ToPointer(), skipVTables);
        }

        public static SymbolContext __CreateInstance(SymbolContext.Internal native, bool skipVTables = false)
        {
            return new SymbolContext(native, skipVTables);
        }

        private static void* __CopyValue(SymbolContext.Internal native)
        {
            var ret = Marshal.AllocHGlobal(4);
            LLDB.SymbolContext.Internal.cctor_1(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private SymbolContext(SymbolContext.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected SymbolContext(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public SymbolContext()
        {
            __Instance = Marshal.AllocHGlobal(4);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public SymbolContext(LLDB.SymbolContext rhs)
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
            LLDB.SymbolContext __dummy;
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

        public LLDB.Module GetModule()
        {
            var __ret = new LLDB.Module.Internal();
            Internal.GetModule_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
            return LLDB.Module.__CreateInstance(__ret);
        }

        public LLDB.CompileUnit GetCompileUnit()
        {
            var __ret = new LLDB.CompileUnit.Internal();
            Internal.GetCompileUnit_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
            return LLDB.CompileUnit.__CreateInstance(__ret);
        }

        public LLDB.Function GetFunction()
        {
            var __ret = new LLDB.Function.Internal();
            Internal.GetFunction_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
            return LLDB.Function.__CreateInstance(__ret);
        }

        public LLDB.Block GetBlock()
        {
            var __ret = new LLDB.Block.Internal();
            Internal.GetBlock_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
            return LLDB.Block.__CreateInstance(__ret);
        }

        public LLDB.LineEntry GetLineEntry()
        {
            var __ret = new LLDB.LineEntry.Internal();
            Internal.GetLineEntry_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
            return LLDB.LineEntry.__CreateInstance(__ret);
        }

        public LLDB.Symbol GetSymbol()
        {
            var __ret = new LLDB.Symbol.Internal();
            Internal.GetSymbol_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
            return LLDB.Symbol.__CreateInstance(__ret);
        }

        public LLDB.SymbolContext GetParentOfInlinedScope(LLDB.Address curr_frame_pc, LLDB.Address parent_frame_addr)
        {
            if (ReferenceEquals(curr_frame_pc, null))
                throw new global::System.ArgumentNullException("curr_frame_pc", "Cannot be null because it is a C++ reference (&).");
            var arg0 = curr_frame_pc.__Instance;
            if (ReferenceEquals(parent_frame_addr, null))
                throw new global::System.ArgumentNullException("parent_frame_addr", "Cannot be null because it is a C++ reference (&).");
            var arg1 = parent_frame_addr.__Instance;
            var __ret = new LLDB.SymbolContext.Internal();
            Internal.GetParentOfInlinedScope_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), arg0, arg1);
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

        public LLDB.Module Module
        {
            set
            {
                var arg0 = ReferenceEquals(value, null) ? new LLDB.Module.Internal() : *(LLDB.Module.Internal*) (value.__Instance);
                Internal.SetModule_0((__Instance + __PointerAdjustment), arg0);
            }
        }

        public LLDB.CompileUnit CompileUnit
        {
            set
            {
                var arg0 = ReferenceEquals(value, null) ? new LLDB.CompileUnit.Internal() : *(LLDB.CompileUnit.Internal*) (value.__Instance);
                Internal.SetCompileUnit_0((__Instance + __PointerAdjustment), arg0);
            }
        }

        public LLDB.Function Function
        {
            set
            {
                var arg0 = ReferenceEquals(value, null) ? new LLDB.Function.Internal() : *(LLDB.Function.Internal*) (value.__Instance);
                Internal.SetFunction_0((__Instance + __PointerAdjustment), arg0);
            }
        }

        public LLDB.Block Block
        {
            set
            {
                var arg0 = ReferenceEquals(value, null) ? new LLDB.Block.Internal() : *(LLDB.Block.Internal*) (value.__Instance);
                Internal.SetBlock_0((__Instance + __PointerAdjustment), arg0);
            }
        }

        public LLDB.LineEntry LineEntry
        {
            set
            {
                var arg0 = ReferenceEquals(value, null) ? new LLDB.LineEntry.Internal() : *(LLDB.LineEntry.Internal*) (value.__Instance);
                Internal.SetLineEntry_0((__Instance + __PointerAdjustment), arg0);
            }
        }

        public LLDB.Symbol Symbol
        {
            set
            {
                var arg0 = ReferenceEquals(value, null) ? new LLDB.Symbol.Internal() : *(LLDB.Symbol.Internal*) (value.__Instance);
                Internal.SetSymbol_0((__Instance + __PointerAdjustment), arg0);
            }
        }
    }
}
