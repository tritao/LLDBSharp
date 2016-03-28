//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class CompileUnit : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct Internal
        {
            [FieldOffset(0)]
            public global::System.IntPtr m_opaque_ptr;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb13SBCompileUnitC2Ev")]
            internal static extern void ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb13SBCompileUnitC2ERKS0_")]
            internal static extern void cctor_1(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb13SBCompileUnitD2Ev")]
            internal static extern void dtor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb13SBCompileUnit7IsValidEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb13SBCompileUnit11GetFileSpecEv")]
            internal static extern void GetFileSpec_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb13SBCompileUnit19GetLineEntryAtIndexEj")]
            internal static extern void GetLineEntryAtIndex_0(global::System.IntPtr @return, global::System.IntPtr instance, uint idx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb13SBCompileUnit18FindLineEntryIndexEjjPNS_10SBFileSpecE")]
            internal static extern uint FindLineEntryIndex_0(global::System.IntPtr instance, uint start_idx, uint line, global::System.IntPtr inline_file_spec);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb13SBCompileUnit18FindLineEntryIndexEjjPNS_10SBFileSpecEb")]
            internal static extern uint FindLineEntryIndex_1(global::System.IntPtr instance, uint start_idx, uint line, global::System.IntPtr inline_file_spec, bool exact);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb13SBCompileUnit21GetSupportFileAtIndexEj")]
            internal static extern void GetSupportFileAtIndex_0(global::System.IntPtr @return, global::System.IntPtr instance, uint idx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb13SBCompileUnit20FindSupportFileIndexEjRKNS_10SBFileSpecEb")]
            internal static extern uint FindSupportFileIndex_0(global::System.IntPtr instance, uint start_idx, global::System.IntPtr sb_file, bool full);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb13SBCompileUnit8GetTypesEj")]
            internal static extern void GetTypes_0(global::System.IntPtr @return, global::System.IntPtr instance, uint type_mask);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb13SBCompileUniteqERKS0_")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool OperatorEqualEqual_0(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb13SBCompileUnitneERKS0_")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool OperatorExclaimEqual_0(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb13SBCompileUnit14GetDescriptionERNS_8SBStreamE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetDescription_0(global::System.IntPtr instance, global::System.IntPtr description);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb13SBCompileUnit17GetNumLineEntriesEv")]
            internal static extern uint GetNumLineEntries_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb13SBCompileUnit18GetNumSupportFilesEv")]
            internal static extern uint GetNumSupportFiles_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb13SBCompileUnit11GetLanguageEv")]
            internal static extern LLDB.LanguageType GetLanguage_0(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, CompileUnit> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, CompileUnit>();

        private readonly bool __ownsNativeInstance;

        public static CompileUnit __CreateInstance(global::System.IntPtr native)
        {
            return new CompileUnit((CompileUnit.Internal*) native);
        }

        public static CompileUnit __CreateInstance(CompileUnit.Internal native)
        {
            return new CompileUnit(native);
        }

        private static CompileUnit.Internal* __CopyValue(CompileUnit.Internal native)
        {
            var ret = (CompileUnit.Internal*) Marshal.AllocHGlobal(4);
            *ret = native;
            return ret;
        }

        private CompileUnit(CompileUnit.Internal native)
            : this(__CopyValue(native))
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CompileUnit(CompileUnit.Internal* native, bool isInternalImpl = false)
        {
            __Instance = new global::System.IntPtr(native);
        }

        public CompileUnit()
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
            LLDB.CompileUnit __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance || force)
                Internal.dtor_0(__Instance);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }

        public bool IsValid()
        {
            var __ret = Internal.IsValid_0(__Instance);
            return __ret;
        }

        public LLDB.FileSpec GetFileSpec()
        {
            var __ret = new LLDB.FileSpec.Internal();
            Internal.GetFileSpec_0(new IntPtr(&__ret), __Instance);
            return LLDB.FileSpec.__CreateInstance(__ret);
        }

        public LLDB.LineEntry GetLineEntryAtIndex(uint idx)
        {
            var arg0 = idx;
            var __ret = new LLDB.LineEntry.Internal();
            Internal.GetLineEntryAtIndex_0(new IntPtr(&__ret), __Instance, arg0);
            return LLDB.LineEntry.__CreateInstance(__ret);
        }

        public uint FindLineEntryIndex(uint start_idx, uint line, LLDB.FileSpec inline_file_spec)
        {
            var arg0 = start_idx;
            var arg1 = line;
            var arg2 = ReferenceEquals(inline_file_spec, null) ? global::System.IntPtr.Zero : inline_file_spec.__Instance;
            var __ret = Internal.FindLineEntryIndex_0(__Instance, arg0, arg1, arg2);
            return __ret;
        }

        public uint FindLineEntryIndex(uint start_idx, uint line, LLDB.FileSpec inline_file_spec, bool exact)
        {
            var arg0 = start_idx;
            var arg1 = line;
            var arg2 = ReferenceEquals(inline_file_spec, null) ? global::System.IntPtr.Zero : inline_file_spec.__Instance;
            var __ret = Internal.FindLineEntryIndex_1(__Instance, arg0, arg1, arg2, exact);
            return __ret;
        }

        public LLDB.FileSpec GetSupportFileAtIndex(uint idx)
        {
            var arg0 = idx;
            var __ret = new LLDB.FileSpec.Internal();
            Internal.GetSupportFileAtIndex_0(new IntPtr(&__ret), __Instance, arg0);
            return LLDB.FileSpec.__CreateInstance(__ret);
        }

        public uint FindSupportFileIndex(uint start_idx, LLDB.FileSpec sb_file, bool full)
        {
            var arg0 = start_idx;
            var arg1 = ReferenceEquals(sb_file, null) ? global::System.IntPtr.Zero : sb_file.__Instance;
            var __ret = Internal.FindSupportFileIndex_0(__Instance, arg0, arg1, full);
            return __ret;
        }

        /// <summary>
        /// <para>Get all types matching type_mask from debug info in this compile
        /// unit.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// Get all types matching \a type_mask from debug info in
        /// this</para>
        /// <para>    /// compile unit.</para>
        /// <para>    ///</para>
        /// <para>    /// @param[in] type_mask</para>
        /// <para>    ///    A bitfield that consists of one or more bits logically
        /// OR'ed</para>
        /// <para>    ///    together from the lldb::TypeClass enumeration. This
        /// allows</para>
        /// <para>    ///    you to request only structure types, or only class,
        /// struct</para>
        /// <para>    ///    and union types. Passing in lldb::eTypeClassAny will
        /// return</para>
        /// <para>    ///    all types found in the debug information for this
        /// compile</para>
        /// <para>    ///    unit.</para>
        /// <para>    ///</para>
        /// <para>    /// @return</para>
        /// <para>    ///    A list of types in this compile unit that match \a
        /// type_mask</para>
        /// </remarks>
        public LLDB.TypeList GetTypes(uint type_mask)
        {
            var arg0 = type_mask;
            var __ret = new LLDB.TypeList.Internal();
            Internal.GetTypes_0(new IntPtr(&__ret), __Instance, arg0);
            return LLDB.TypeList.__CreateInstance(__ret);
        }

        public static bool operator ==(LLDB.CompileUnit __op, LLDB.CompileUnit rhs)
        {
            bool __opNull = ReferenceEquals(__op, null);
            bool rhsNull = ReferenceEquals(rhs, null);
            if (__opNull || rhsNull)
                return __opNull && rhsNull;
            var arg0 = __op.__Instance;
            var arg1 = rhs.__Instance;
            var __ret = Internal.OperatorEqualEqual_0(arg0, arg1);
            return __ret;
        }

        public override bool Equals(object obj)
        {
            return this == obj as CompileUnit;
        }

        public static bool operator !=(LLDB.CompileUnit __op, LLDB.CompileUnit rhs)
        {
            var arg0 = ReferenceEquals(__op, null) ? global::System.IntPtr.Zero : __op.__Instance;
            var arg1 = ReferenceEquals(rhs, null) ? global::System.IntPtr.Zero : rhs.__Instance;
            var __ret = Internal.OperatorExclaimEqual_0(arg0, arg1);
            return __ret;
        }

        public bool GetDescription(LLDB.Stream description)
        {
            var arg0 = ReferenceEquals(description, null) ? global::System.IntPtr.Zero : description.__Instance;
            var __ret = Internal.GetDescription_0(__Instance, arg0);
            return __ret;
        }

        public uint NumLineEntries
        {
            get
            {
                var __ret = Internal.GetNumLineEntries_0(__Instance);
                return __ret;
            }
        }

        public uint NumSupportFiles
        {
            get
            {
                var __ret = Internal.GetNumSupportFiles_0(__Instance);
                return __ret;
            }
        }

        public LLDB.LanguageType Language
        {
            get
            {
                var __ret = Internal.GetLanguage_0(__Instance);
                return __ret;
            }
        }
    }
}