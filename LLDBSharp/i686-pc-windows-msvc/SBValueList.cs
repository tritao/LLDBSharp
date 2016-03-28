//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class ValueList : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBValueList@lldb@@QAE@XZ")]
            internal static extern global::System.IntPtr ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBValueList@lldb@@QAE@ABV01@@Z")]
            internal static extern global::System.IntPtr cctor_1(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??1SBValueList@lldb@@QAE@XZ")]
            internal static extern void dtor_0(global::System.IntPtr instance, int delete);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?IsValid@SBValueList@lldb@@QBE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?Clear@SBValueList@lldb@@QAEXXZ")]
            internal static extern void Clear_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?Append@SBValueList@lldb@@QAEXABVSBValue@2@@Z")]
            internal static extern void Append_0(global::System.IntPtr instance, global::System.IntPtr val_obj);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?Append@SBValueList@lldb@@QAEXABV12@@Z")]
            internal static extern void Append_1(global::System.IntPtr instance, global::System.IntPtr value_list);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetValueAtIndex@SBValueList@lldb@@QBE?AVSBValue@2@I@Z")]
            internal static extern void GetValueAtIndex_0(global::System.IntPtr instance, global::System.IntPtr @return, uint idx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetFirstValueByName@SBValueList@lldb@@QBE?AVSBValue@2@PBD@Z")]
            internal static extern void GetFirstValueByName_0(global::System.IntPtr instance, global::System.IntPtr @return, global::System.IntPtr name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?FindValueObjectByUID@SBValueList@lldb@@QAE?AVSBValue@2@_K@Z")]
            internal static extern void FindValueObjectByUID_0(global::System.IntPtr instance, global::System.IntPtr @return, ulong uid);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?opaque_ptr@SBValueList@lldb@@IAEPAXXZ")]
            internal static extern global::System.IntPtr opaque_ptr_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetSize@SBValueList@lldb@@QBEIXZ")]
            internal static extern uint GetSize_0(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, ValueList> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, ValueList>();

        private readonly bool __ownsNativeInstance;

        public static ValueList __CreateInstance(global::System.IntPtr native)
        {
            return new ValueList((ValueList.Internal*) native);
        }

        public static ValueList __CreateInstance(ValueList.Internal native)
        {
            return new ValueList(native);
        }

        private static ValueList.Internal* __CopyValue(ValueList.Internal native)
        {
            var ret = (ValueList.Internal*) Marshal.AllocHGlobal(4);
            *ret = native;
            return ret;
        }

        private ValueList(ValueList.Internal native)
            : this(__CopyValue(native))
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ValueList(ValueList.Internal* native, bool isInternalImpl = false)
        {
            __Instance = new global::System.IntPtr(native);
        }

        public ValueList()
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
            LLDB.ValueList __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance || force)
                Internal.dtor_0(__Instance, 0);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }

        public bool IsValid()
        {
            var __ret = Internal.IsValid_0(__Instance);
            return __ret;
        }

        public void Clear()
        {
            Internal.Clear_0(__Instance);
        }

        public void Append(LLDB.Value val_obj)
        {
            var arg0 = ReferenceEquals(val_obj, null) ? global::System.IntPtr.Zero : val_obj.__Instance;
            Internal.Append_0(__Instance, arg0);
        }

        public void Append(LLDB.ValueList value_list)
        {
            var arg0 = ReferenceEquals(value_list, null) ? global::System.IntPtr.Zero : value_list.__Instance;
            Internal.Append_1(__Instance, arg0);
        }

        public LLDB.Value GetValueAtIndex(uint idx)
        {
            var arg0 = idx;
            var __ret = new LLDB.Value.Internal();
            Internal.GetValueAtIndex_0(__Instance, new IntPtr(&__ret), arg0);
            return LLDB.Value.__CreateInstance(__ret);
        }

        public LLDB.Value GetFirstValueByName(string name)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(name);
            var __ret = new LLDB.Value.Internal();
            Internal.GetFirstValueByName_0(__Instance, new IntPtr(&__ret), arg0);
            Marshal.FreeHGlobal(arg0);
            return LLDB.Value.__CreateInstance(__ret);
        }

        public LLDB.Value FindValueObjectByUID(ulong uid)
        {
            var arg0 = uid;
            var __ret = new LLDB.Value.Internal();
            Internal.FindValueObjectByUID_0(__Instance, new IntPtr(&__ret), arg0);
            return LLDB.Value.__CreateInstance(__ret);
        }

        protected global::System.IntPtr opaque_ptr()
        {
            var __ret = Internal.opaque_ptr_0(__Instance);
            return __ret;
        }

        public uint Size
        {
            get
            {
                var __ret = Internal.GetSize_0(__Instance);
                return __ret;
            }
        }
    }
}