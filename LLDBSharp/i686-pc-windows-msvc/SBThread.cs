//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class Thread : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBThread@lldb@@QAE@XZ")]
            internal static extern global::System.IntPtr ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBThread@lldb@@QAE@ABV01@@Z")]
            internal static extern global::System.IntPtr cctor_1(global::System.IntPtr instance, global::System.IntPtr thread);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??1SBThread@lldb@@QAE@XZ")]
            internal static extern void dtor_0(global::System.IntPtr instance, int delete);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetQueue@SBThread@lldb@@QBE?AVSBQueue@2@XZ")]
            internal static extern void GetQueue_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?IsValid@SBThread@lldb@@QBE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?Clear@SBThread@lldb@@QAEXXZ")]
            internal static extern void Clear_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetStopReasonDataAtIndex@SBThread@lldb@@QAE_KI@Z")]
            internal static extern ulong GetStopReasonDataAtIndex_0(global::System.IntPtr instance, uint idx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetStopReasonExtendedInfoAsJSON@SBThread@lldb@@QAE_NAAVSBStream@2@@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetStopReasonExtendedInfoAsJSON_0(global::System.IntPtr instance, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetStopDescription@SBThread@lldb@@QAEIPADI@Z")]
            internal static extern uint GetStopDescription_0(global::System.IntPtr instance, sbyte* dst, uint dst_len);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetStopReturnValue@SBThread@lldb@@QAE?AVSBValue@2@XZ")]
            internal static extern void GetStopReturnValue_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetInfoItemByPathAsString@SBThread@lldb@@QAE_NPBDAAVSBStream@2@@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetInfoItemByPathAsString_0(global::System.IntPtr instance, global::System.IntPtr path, global::System.IntPtr strm);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?StepOver@SBThread@lldb@@QAEXW4RunMode@2@@Z")]
            internal static extern void StepOver_0(global::System.IntPtr instance, LLDB.RunMode stop_other_threads);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?StepInto@SBThread@lldb@@QAEXW4RunMode@2@@Z")]
            internal static extern void StepInto_0(global::System.IntPtr instance, LLDB.RunMode stop_other_threads);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?StepInto@SBThread@lldb@@QAEXPBDW4RunMode@2@@Z")]
            internal static extern void StepInto_1(global::System.IntPtr instance, global::System.IntPtr target_name, LLDB.RunMode stop_other_threads);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?StepOut@SBThread@lldb@@QAEXXZ")]
            internal static extern void StepOut_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?StepOutOfFrame@SBThread@lldb@@QAEXAAVSBFrame@2@@Z")]
            internal static extern void StepOutOfFrame_0(global::System.IntPtr instance, global::System.IntPtr frame);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?StepInstruction@SBThread@lldb@@QAEX_N@Z")]
            internal static extern void StepInstruction_0(global::System.IntPtr instance, bool step_over);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?StepOverUntil@SBThread@lldb@@QAE?AVSBError@2@AAVSBFrame@2@AAVSBFileSpec@2@I@Z")]
            internal static extern void StepOverUntil_0(global::System.IntPtr instance, global::System.IntPtr @return, global::System.IntPtr frame, global::System.IntPtr file_spec, uint line);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?StepUsingScriptedThreadPlan@SBThread@lldb@@QAE?AVSBError@2@PBD@Z")]
            internal static extern void StepUsingScriptedThreadPlan_0(global::System.IntPtr instance, global::System.IntPtr @return, global::System.IntPtr script_class_name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?JumpToLine@SBThread@lldb@@QAE?AVSBError@2@AAVSBFileSpec@2@I@Z")]
            internal static extern void JumpToLine_0(global::System.IntPtr instance, global::System.IntPtr @return, global::System.IntPtr file_spec, uint line);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?RunToAddress@SBThread@lldb@@QAEX_K@Z")]
            internal static extern void RunToAddress_0(global::System.IntPtr instance, ulong addr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?ReturnFromFrame@SBThread@lldb@@QAE?AVSBError@2@AAVSBFrame@2@AAVSBValue@2@@Z")]
            internal static extern void ReturnFromFrame_0(global::System.IntPtr instance, global::System.IntPtr @return, global::System.IntPtr frame, global::System.IntPtr return_value);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?Suspend@SBThread@lldb@@QAE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool Suspend_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?Resume@SBThread@lldb@@QAE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool Resume_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?IsSuspended@SBThread@lldb@@QAE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsSuspended_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?IsStopped@SBThread@lldb@@QAE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsStopped_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetFrameAtIndex@SBThread@lldb@@QAE?AVSBFrame@2@I@Z")]
            internal static extern void GetFrameAtIndex_0(global::System.IntPtr instance, global::System.IntPtr @return, uint idx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetSelectedFrame@SBThread@lldb@@QAE?AVSBFrame@2@XZ")]
            internal static extern void GetSelectedFrame_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetSelectedFrame@SBThread@lldb@@QAE?AVSBFrame@2@I@Z")]
            internal static extern void SetSelectedFrame_0(global::System.IntPtr instance, global::System.IntPtr @return, uint frame_idx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?EventIsThreadEvent@SBThread@lldb@@SA_NABVSBEvent@2@@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool EventIsThreadEvent_0(global::System.IntPtr @event);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetStackFrameFromEvent@SBThread@lldb@@SA?AVSBFrame@2@ABVSBEvent@2@@Z")]
            internal static extern void GetStackFrameFromEvent_0(global::System.IntPtr @return, global::System.IntPtr @event);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetThreadFromEvent@SBThread@lldb@@SA?AV12@ABVSBEvent@2@@Z")]
            internal static extern void GetThreadFromEvent_0(global::System.IntPtr @return, global::System.IntPtr @event);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetProcess@SBThread@lldb@@QAE?AVSBProcess@2@XZ")]
            internal static extern void GetProcess_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??8SBThread@lldb@@QBE_NABV01@@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool OperatorEqualEqual_0(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??9SBThread@lldb@@QBE_NABV01@@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool OperatorExclaimEqual_0(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetDescription@SBThread@lldb@@QBE_NAAVSBStream@2@@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetDescription_0(global::System.IntPtr instance, global::System.IntPtr description);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetStatus@SBThread@lldb@@QBE_NAAVSBStream@2@@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetStatus_0(global::System.IntPtr instance, global::System.IntPtr status);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetExtendedBacktraceThread@SBThread@lldb@@QAE?AV12@PBD@Z")]
            internal static extern void GetExtendedBacktraceThread_0(global::System.IntPtr instance, global::System.IntPtr @return, global::System.IntPtr type);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SafeToCallFunctions@SBThread@lldb@@QAE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool SafeToCallFunctions_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetBroadcasterClassName@SBThread@lldb@@SAPBDXZ")]
            internal static extern global::System.IntPtr GetBroadcasterClassName_0();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetStopReason@SBThread@lldb@@QAE?AW4StopReason@2@XZ")]
            internal static extern LLDB.StopReason GetStopReason_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetStopReasonDataCount@SBThread@lldb@@QAEIXZ")]
            internal static extern uint GetStopReasonDataCount_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetThreadID@SBThread@lldb@@QBE_KXZ")]
            internal static extern ulong GetThreadID_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetIndexID@SBThread@lldb@@QBEIXZ")]
            internal static extern uint GetIndexID_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetName@SBThread@lldb@@QBEPBDXZ")]
            internal static extern global::System.IntPtr GetName_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetQueueName@SBThread@lldb@@QBEPBDXZ")]
            internal static extern global::System.IntPtr GetQueueName_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetQueueID@SBThread@lldb@@QBE_KXZ")]
            internal static extern ulong GetQueueID_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetNumFrames@SBThread@lldb@@QAEIXZ")]
            internal static extern uint GetNumFrames_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetExtendedBacktraceOriginatingIndexID@SBThread@lldb@@QAEIXZ")]
            internal static extern uint GetExtendedBacktraceOriginatingIndexID_0(global::System.IntPtr instance);
        }

        [Flags]
        public enum BroadcastBit
        {
            BroadcastBitStackChanged = 1,
            BroadcastBitThreadSuspended = 2,
            BroadcastBitThreadResumed = 4,
            BroadcastBitSelectedFrameChanged = 8,
            BroadcastBitThreadSelected = 16
        }

        public global::System.IntPtr __Instance { get; protected set; }
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Thread> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Thread>();

        private readonly bool __ownsNativeInstance;

        public static Thread __CreateInstance(global::System.IntPtr native)
        {
            return new Thread((Thread.Internal*) native);
        }

        public static Thread __CreateInstance(Thread.Internal native)
        {
            return new Thread(native);
        }

        private static Thread.Internal* __CopyValue(Thread.Internal native)
        {
            var ret = (Thread.Internal*) Marshal.AllocHGlobal(8);
            *ret = native;
            return ret;
        }

        private Thread(Thread.Internal native)
            : this(__CopyValue(native))
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Thread(Thread.Internal* native, bool isInternalImpl = false)
        {
            __Instance = new global::System.IntPtr(native);
        }

        public Thread()
        {
            __Instance = Marshal.AllocHGlobal(8);
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
            LLDB.Thread __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance || force)
                Internal.dtor_0(__Instance, 0);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }

        public LLDB.Queue GetQueue()
        {
            var __ret = new LLDB.Queue.Internal();
            Internal.GetQueue_0(__Instance, new IntPtr(&__ret));
            return LLDB.Queue.__CreateInstance(__ret);
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

        /// <summary>
        /// <para>Get information associated with a stop reason.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// Get information associated with a stop reason.</para>
        /// <para></para>
        /// <para>    ///</para>
        /// <para></para>
        /// <para>    /// Breakpoint stop reasons will have data that consists of
        /// pairs of </para>
        /// <para></para>
        /// <para>    /// breakpoint IDs followed by the breakpoint location IDs
        /// (they always come</para>
        /// <para></para>
        /// <para>    /// in pairs).</para>
        /// <para></para>
        /// <para>    ///</para>
        /// <para></para>
        /// <para>    /// Stop Reason              Count Data Type</para>
        /// <para></para>
        /// <para>    /// ======================== =====
        /// =========================================</para>
        /// <para></para>
        /// <para>    /// eStopReasonNone          0</para>
        /// <para></para>
        /// <para>    /// eStopReasonTrace         0</para>
        /// <para></para>
        /// <para>    /// eStopReasonBreakpoint    N     duple: {breakpoint id,
        /// location id}</para>
        /// <para></para>
        /// <para>    /// eStopReasonWatchpoint    1     watchpoint id</para>
        /// <para></para>
        /// <para>    /// eStopReasonSignal        1     unix signal number</para>
        /// <para></para>
        /// <para>    /// eStopReasonException     N     exception data</para>
        /// <para></para>
        /// <para>    /// eStopReasonExec          0</para>
        /// <para></para>
        /// <para>    /// eStopReasonPlanComplete  0</para>
        /// </remarks>
        public ulong GetStopReasonDataAtIndex(uint idx)
        {
            var arg0 = idx;
            var __ret = Internal.GetStopReasonDataAtIndex_0(__Instance, arg0);
            return __ret;
        }

        public bool GetStopReasonExtendedInfoAsJSON(LLDB.Stream stream)
        {
            var arg0 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = Internal.GetStopReasonExtendedInfoAsJSON_0(__Instance, arg0);
            return __ret;
        }

        public uint GetStopDescription(sbyte* dst, uint dst_len)
        {
            var arg0 = dst;
            var arg1 = dst_len;
            var __ret = Internal.GetStopDescription_0(__Instance, arg0, arg1);
            return __ret;
        }

        public LLDB.Value GetStopReturnValue()
        {
            var __ret = new LLDB.Value.Internal();
            Internal.GetStopReturnValue_0(__Instance, new IntPtr(&__ret));
            return LLDB.Value.__CreateInstance(__ret);
        }

        public bool GetInfoItemByPathAsString(string path, LLDB.Stream strm)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(path);
            var arg1 = ReferenceEquals(strm, null) ? global::System.IntPtr.Zero : strm.__Instance;
            var __ret = Internal.GetInfoItemByPathAsString_0(__Instance, arg0, arg1);
            Marshal.FreeHGlobal(arg0);
            return __ret;
        }

        public void StepOver(LLDB.RunMode stop_other_threads)
        {
            var arg0 = stop_other_threads;
            Internal.StepOver_0(__Instance, arg0);
        }

        public void StepInto(LLDB.RunMode stop_other_threads)
        {
            var arg0 = stop_other_threads;
            Internal.StepInto_0(__Instance, arg0);
        }

        public void StepInto(string target_name, LLDB.RunMode stop_other_threads)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(target_name);
            var arg1 = stop_other_threads;
            Internal.StepInto_1(__Instance, arg0, arg1);
            Marshal.FreeHGlobal(arg0);
        }

        public void StepOut()
        {
            Internal.StepOut_0(__Instance);
        }

        public void StepOutOfFrame(LLDB.Frame frame)
        {
            var arg0 = ReferenceEquals(frame, null) ? global::System.IntPtr.Zero : frame.__Instance;
            Internal.StepOutOfFrame_0(__Instance, arg0);
        }

        public void StepInstruction(bool step_over)
        {
            Internal.StepInstruction_0(__Instance, step_over);
        }

        public LLDB.Error StepOverUntil(LLDB.Frame frame, LLDB.FileSpec file_spec, uint line)
        {
            var arg0 = ReferenceEquals(frame, null) ? global::System.IntPtr.Zero : frame.__Instance;
            var arg1 = ReferenceEquals(file_spec, null) ? global::System.IntPtr.Zero : file_spec.__Instance;
            var arg2 = line;
            var __ret = new LLDB.Error.Internal();
            Internal.StepOverUntil_0(__Instance, new IntPtr(&__ret), arg0, arg1, arg2);
            return LLDB.Error.__CreateInstance(__ret);
        }

        public LLDB.Error StepUsingScriptedThreadPlan(string script_class_name)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(script_class_name);
            var __ret = new LLDB.Error.Internal();
            Internal.StepUsingScriptedThreadPlan_0(__Instance, new IntPtr(&__ret), arg0);
            Marshal.FreeHGlobal(arg0);
            return LLDB.Error.__CreateInstance(__ret);
        }

        public LLDB.Error JumpToLine(LLDB.FileSpec file_spec, uint line)
        {
            var arg0 = ReferenceEquals(file_spec, null) ? global::System.IntPtr.Zero : file_spec.__Instance;
            var arg1 = line;
            var __ret = new LLDB.Error.Internal();
            Internal.JumpToLine_0(__Instance, new IntPtr(&__ret), arg0, arg1);
            return LLDB.Error.__CreateInstance(__ret);
        }

        public void RunToAddress(ulong addr)
        {
            var arg0 = addr;
            Internal.RunToAddress_0(__Instance, arg0);
        }

        public LLDB.Error ReturnFromFrame(LLDB.Frame frame, LLDB.Value return_value)
        {
            var arg0 = ReferenceEquals(frame, null) ? global::System.IntPtr.Zero : frame.__Instance;
            var arg1 = ReferenceEquals(return_value, null) ? global::System.IntPtr.Zero : return_value.__Instance;
            var __ret = new LLDB.Error.Internal();
            Internal.ReturnFromFrame_0(__Instance, new IntPtr(&__ret), arg0, arg1);
            return LLDB.Error.__CreateInstance(__ret);
        }

        /// <summary>
        /// <para>LLDB currently supports process centric debugging which means
        /// when any thread in a process stops, all other threads are stopped. The
        /// Suspend() call here tells our process to suspend a thread and not let it
        /// run when the other threads in a process are allowed to run. So when
        /// SBProcess::Continue() is called, any threads that aren't suspended will be
        /// allowed to run. If any of the SBThread functions for stepping are called
        /// (StepOver, StepInto, StepOut, StepInstruction, RunToAddress), the thread
        /// will not be allowed to run and these functions will simply return.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// LLDB currently supports process centric debugging which means
        /// when any</para>
        /// <para></para>
        /// <para>    /// thread in a process stops, all other threads are stopped.
        /// The Suspend()</para>
        /// <para></para>
        /// <para>    /// call here tells our process to suspend a thread and not
        /// let it run when</para>
        /// <para></para>
        /// <para>    /// the other threads in a process are allowed to run. So
        /// when </para>
        /// <para></para>
        /// <para>    /// SBProcess::Continue() is called, any threads that aren't
        /// suspended will</para>
        /// <para></para>
        /// <para>    /// be allowed to run. If any of the SBThread functions for
        /// stepping are </para>
        /// <para></para>
        /// <para>    /// called (StepOver, StepInto, StepOut, StepInstruction,
        /// RunToAddress), the</para>
        /// <para></para>
        /// <para>    /// thread will not be allowed to run and these functions
        /// will simply return.</para>
        /// <para></para>
        /// <para>    ///</para>
        /// <para></para>
        /// <para>    /// Eventually we plan to add support for thread centric
        /// debugging where</para>
        /// <para></para>
        /// <para>    /// each thread is controlled individually and each thread
        /// would broadcast</para>
        /// <para></para>
        /// <para>    /// its state, but we haven't implemented this yet.</para>
        /// <para></para>
        /// <para>    /// </para>
        /// <para></para>
        /// <para>    /// Likewise the SBThread::Resume() call will again allow the
        /// thread to run</para>
        /// <para></para>
        /// <para>    /// when the process is continued.</para>
        /// <para></para>
        /// <para>    ///</para>
        /// <para></para>
        /// <para>    /// Suspend() and Resume() functions are not currently
        /// reference counted, if</para>
        /// <para></para>
        /// <para>    /// anyone has the need for them to be reference counted,
        /// please let us</para>
        /// <para></para>
        /// <para>    /// know.</para>
        /// </remarks>
        public bool Suspend()
        {
            var __ret = Internal.Suspend_0(__Instance);
            return __ret;
        }

        public bool Resume()
        {
            var __ret = Internal.Resume_0(__Instance);
            return __ret;
        }

        public bool IsSuspended()
        {
            var __ret = Internal.IsSuspended_0(__Instance);
            return __ret;
        }

        public bool IsStopped()
        {
            var __ret = Internal.IsStopped_0(__Instance);
            return __ret;
        }

        public LLDB.Frame GetFrameAtIndex(uint idx)
        {
            var arg0 = idx;
            var __ret = new LLDB.Frame.Internal();
            Internal.GetFrameAtIndex_0(__Instance, new IntPtr(&__ret), arg0);
            return LLDB.Frame.__CreateInstance(__ret);
        }

        public LLDB.Frame GetSelectedFrame()
        {
            var __ret = new LLDB.Frame.Internal();
            Internal.GetSelectedFrame_0(__Instance, new IntPtr(&__ret));
            return LLDB.Frame.__CreateInstance(__ret);
        }

        public LLDB.Frame SetSelectedFrame(uint frame_idx)
        {
            var arg0 = frame_idx;
            var __ret = new LLDB.Frame.Internal();
            Internal.SetSelectedFrame_0(__Instance, new IntPtr(&__ret), arg0);
            return LLDB.Frame.__CreateInstance(__ret);
        }

        public LLDB.Process GetProcess()
        {
            var __ret = new LLDB.Process.Internal();
            Internal.GetProcess_0(__Instance, new IntPtr(&__ret));
            return LLDB.Process.__CreateInstance(__ret);
        }

        public static bool operator ==(LLDB.Thread __op, LLDB.Thread rhs)
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
            return this == obj as Thread;
        }

        public static bool operator !=(LLDB.Thread __op, LLDB.Thread rhs)
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

        public bool GetStatus(LLDB.Stream status)
        {
            var arg0 = ReferenceEquals(status, null) ? global::System.IntPtr.Zero : status.__Instance;
            var __ret = Internal.GetStatus_0(__Instance, arg0);
            return __ret;
        }

        public LLDB.Thread GetExtendedBacktraceThread(string type)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(type);
            var __ret = new LLDB.Thread.Internal();
            Internal.GetExtendedBacktraceThread_0(__Instance, new IntPtr(&__ret), arg0);
            Marshal.FreeHGlobal(arg0);
            return LLDB.Thread.__CreateInstance(__ret);
        }

        public bool SafeToCallFunctions()
        {
            var __ret = Internal.SafeToCallFunctions_0(__Instance);
            return __ret;
        }

        public static bool EventIsThreadEvent(LLDB.Event @event)
        {
            var arg0 = ReferenceEquals(@event, null) ? global::System.IntPtr.Zero : @event.__Instance;
            var __ret = Internal.EventIsThreadEvent_0(arg0);
            return __ret;
        }

        public static LLDB.Frame GetStackFrameFromEvent(LLDB.Event @event)
        {
            var arg0 = ReferenceEquals(@event, null) ? global::System.IntPtr.Zero : @event.__Instance;
            var __ret = new LLDB.Frame.Internal();
            Internal.GetStackFrameFromEvent_0(new IntPtr(&__ret), arg0);
            return LLDB.Frame.__CreateInstance(__ret);
        }

        public static LLDB.Thread GetThreadFromEvent(LLDB.Event @event)
        {
            var arg0 = ReferenceEquals(@event, null) ? global::System.IntPtr.Zero : @event.__Instance;
            var __ret = new LLDB.Thread.Internal();
            Internal.GetThreadFromEvent_0(new IntPtr(&__ret), arg0);
            return LLDB.Thread.__CreateInstance(__ret);
        }

        public static string BroadcasterClassName
        {
            get
            {
                var __ret = Internal.GetBroadcasterClassName_0();
                return Marshal.PtrToStringAnsi(__ret);
            }
        }

        public LLDB.StopReason StopReason
        {
            get
            {
                var __ret = Internal.GetStopReason_0(__Instance);
                return __ret;
            }
        }

        public uint StopReasonDataCount
        {
            get
            {
                var __ret = Internal.GetStopReasonDataCount_0(__Instance);
                return __ret;
            }
        }

        public ulong ThreadID
        {
            get
            {
                var __ret = Internal.GetThreadID_0(__Instance);
                return __ret;
            }
        }

        public uint IndexID
        {
            get
            {
                var __ret = Internal.GetIndexID_0(__Instance);
                return __ret;
            }
        }

        public string Name
        {
            get
            {
                var __ret = Internal.GetName_0(__Instance);
                return Marshal.PtrToStringAnsi(__ret);
            }
        }

        public string QueueName
        {
            get
            {
                var __ret = Internal.GetQueueName_0(__Instance);
                return Marshal.PtrToStringAnsi(__ret);
            }
        }

        public ulong QueueID
        {
            get
            {
                var __ret = Internal.GetQueueID_0(__Instance);
                return __ret;
            }
        }

        public uint NumFrames
        {
            get
            {
                var __ret = Internal.GetNumFrames_0(__Instance);
                return __ret;
            }
        }

        public uint ExtendedBacktraceOriginatingIndexID
        {
            get
            {
                var __ret = Internal.GetExtendedBacktraceOriginatingIndexID_0(__Instance);
                return __ret;
            }
        }
    }
}