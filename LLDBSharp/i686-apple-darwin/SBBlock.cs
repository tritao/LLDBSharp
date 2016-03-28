//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class Block : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct Internal
        {
            [FieldOffset(0)]
            public global::System.IntPtr m_opaque_ptr;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBBlockC2Ev")]
            internal static extern void ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBBlockC2ERKS0_")]
            internal static extern void cctor_1(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBBlockD2Ev")]
            internal static extern void dtor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb7SBBlock9IsInlinedEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsInlined_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb7SBBlock7IsValidEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb7SBBlock22GetInlinedCallSiteFileEv")]
            internal static extern void GetInlinedCallSiteFile_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBBlock9GetParentEv")]
            internal static extern void GetParent_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBBlock10GetSiblingEv")]
            internal static extern void GetSibling_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBBlock13GetFirstChildEv")]
            internal static extern void GetFirstChild_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBBlock20GetRangeStartAddressEj")]
            internal static extern void GetRangeStartAddress_0(global::System.IntPtr @return, global::System.IntPtr instance, uint idx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBBlock18GetRangeEndAddressEj")]
            internal static extern void GetRangeEndAddress_0(global::System.IntPtr @return, global::System.IntPtr instance, uint idx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBBlock28GetRangeIndexForBlockAddressENS_9SBAddressE")]
            internal static extern uint GetRangeIndexForBlockAddress_0(global::System.IntPtr instance, LLDB.Address.Internal block_addr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBBlock12GetVariablesERNS_7SBFrameEbbbNS_16DynamicValueTypeE")]
            internal static extern void GetVariables_0(global::System.IntPtr @return, global::System.IntPtr instance, global::System.IntPtr frame, bool arguments, bool locals, bool statics, LLDB.DynamicValueType use_dynamic);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBBlock12GetVariablesERNS_8SBTargetEbbb")]
            internal static extern void GetVariables_1(global::System.IntPtr @return, global::System.IntPtr instance, global::System.IntPtr target, bool arguments, bool locals, bool statics);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBBlock25GetContainingInlinedBlockEv")]
            internal static extern void GetContainingInlinedBlock_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBBlock14GetDescriptionERNS_8SBStreamE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetDescription_0(global::System.IntPtr instance, global::System.IntPtr description);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb7SBBlock14GetInlinedNameEv")]
            internal static extern global::System.IntPtr GetInlinedName_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb7SBBlock22GetInlinedCallSiteLineEv")]
            internal static extern uint GetInlinedCallSiteLine_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb7SBBlock24GetInlinedCallSiteColumnEv")]
            internal static extern uint GetInlinedCallSiteColumn_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBBlock12GetNumRangesEv")]
            internal static extern uint GetNumRanges_0(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Block> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Block>();

        private readonly bool __ownsNativeInstance;

        public static Block __CreateInstance(global::System.IntPtr native)
        {
            return new Block((Block.Internal*) native);
        }

        public static Block __CreateInstance(Block.Internal native)
        {
            return new Block(native);
        }

        private static Block.Internal* __CopyValue(Block.Internal native)
        {
            var ret = (Block.Internal*) Marshal.AllocHGlobal(4);
            *ret = native;
            return ret;
        }

        private Block(Block.Internal native)
            : this(__CopyValue(native))
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Block(Block.Internal* native, bool isInternalImpl = false)
        {
            __Instance = new global::System.IntPtr(native);
        }

        public Block()
        {
            __Instance = Marshal.AllocHGlobal(4);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0(__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        protected virtual void Dispose(bool disposing)
        {
            DestroyNativeInstance(false);
        }

        public virtual void DestroyNativeInstance()
        {
            DestroyNativeInstance(true);
        }

        private void DestroyNativeInstance(bool force)
        {
            LLDB.Block __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance || force)
                Internal.dtor_0(__Instance);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }

        public bool IsInlined()
        {
            var __ret = Internal.IsInlined_0(__Instance);
            return __ret;
        }

        public bool IsValid()
        {
            var __ret = Internal.IsValid_0(__Instance);
            return __ret;
        }

        public LLDB.FileSpec GetInlinedCallSiteFile()
        {
            var __ret = new LLDB.FileSpec.Internal();
            Internal.GetInlinedCallSiteFile_0(new IntPtr(&__ret), __Instance);
            return LLDB.FileSpec.__CreateInstance(__ret);
        }

        public LLDB.Block GetParent()
        {
            var __ret = new LLDB.Block.Internal();
            Internal.GetParent_0(new IntPtr(&__ret), __Instance);
            return LLDB.Block.__CreateInstance(__ret);
        }

        public LLDB.Block GetSibling()
        {
            var __ret = new LLDB.Block.Internal();
            Internal.GetSibling_0(new IntPtr(&__ret), __Instance);
            return LLDB.Block.__CreateInstance(__ret);
        }

        public LLDB.Block GetFirstChild()
        {
            var __ret = new LLDB.Block.Internal();
            Internal.GetFirstChild_0(new IntPtr(&__ret), __Instance);
            return LLDB.Block.__CreateInstance(__ret);
        }

        public LLDB.Address GetRangeStartAddress(uint idx)
        {
            var arg0 = idx;
            var __ret = new LLDB.Address.Internal();
            Internal.GetRangeStartAddress_0(new IntPtr(&__ret), __Instance, arg0);
            return LLDB.Address.__CreateInstance(__ret);
        }

        public LLDB.Address GetRangeEndAddress(uint idx)
        {
            var arg0 = idx;
            var __ret = new LLDB.Address.Internal();
            Internal.GetRangeEndAddress_0(new IntPtr(&__ret), __Instance, arg0);
            return LLDB.Address.__CreateInstance(__ret);
        }

        public uint GetRangeIndexForBlockAddress(LLDB.Address block_addr)
        {
            var arg0 = ReferenceEquals(block_addr, null) ? new LLDB.Address.Internal() : *(LLDB.Address.Internal*) (block_addr.__Instance);
            var __ret = Internal.GetRangeIndexForBlockAddress_0(__Instance, arg0);
            return __ret;
        }

        public LLDB.ValueList GetVariables(LLDB.Frame frame, bool arguments, bool locals, bool statics, LLDB.DynamicValueType use_dynamic)
        {
            var arg0 = ReferenceEquals(frame, null) ? global::System.IntPtr.Zero : frame.__Instance;
            var arg4 = use_dynamic;
            var __ret = new LLDB.ValueList.Internal();
            Internal.GetVariables_0(new IntPtr(&__ret), __Instance, arg0, arguments, locals, statics, arg4);
            return LLDB.ValueList.__CreateInstance(__ret);
        }

        public LLDB.ValueList GetVariables(LLDB.Target target, bool arguments, bool locals, bool statics)
        {
            var arg0 = ReferenceEquals(target, null) ? global::System.IntPtr.Zero : target.__Instance;
            var __ret = new LLDB.ValueList.Internal();
            Internal.GetVariables_1(new IntPtr(&__ret), __Instance, arg0, arguments, locals, statics);
            return LLDB.ValueList.__CreateInstance(__ret);
        }

        /// <summary>
        /// <para>Get the inlined block that contains this block.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// Get the inlined block that contains this block.</para>
        /// <para>    ///</para>
        /// <para>    /// @return</para>
        /// <para>    ///     If this block is inlined, it will return this block,
        /// else </para>
        /// <para>    ///     parent blocks will be searched to see if any contain
        /// this </para>
        /// <para>    ///     block and are themselves inlined. An invalid SBBlock
        /// will </para>
        /// <para>    ///     be returned if this block nor any parent blocks are
        /// inlined</para>
        /// <para>    ///     function blocks.</para>
        /// </remarks>
        public LLDB.Block GetContainingInlinedBlock()
        {
            var __ret = new LLDB.Block.Internal();
            Internal.GetContainingInlinedBlock_0(new IntPtr(&__ret), __Instance);
            return LLDB.Block.__CreateInstance(__ret);
        }

        public bool GetDescription(LLDB.Stream description)
        {
            var arg0 = ReferenceEquals(description, null) ? global::System.IntPtr.Zero : description.__Instance;
            var __ret = Internal.GetDescription_0(__Instance, arg0);
            return __ret;
        }

        public string InlinedName
        {
            get
            {
                var __ret = Internal.GetInlinedName_0(__Instance);
                return Marshal.PtrToStringAnsi(__ret);
            }
        }

        public uint InlinedCallSiteLine
        {
            get
            {
                var __ret = Internal.GetInlinedCallSiteLine_0(__Instance);
                return __ret;
            }
        }

        public uint InlinedCallSiteColumn
        {
            get
            {
                var __ret = Internal.GetInlinedCallSiteColumn_0(__Instance);
                return __ret;
            }
        }

        public uint NumRanges
        {
            get
            {
                var __ret = Internal.GetNumRanges_0(__Instance);
                return __ret;
            }
        }
    }
}