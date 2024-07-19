using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3A7CA4736E4624F0, NameHash = 0x910781C3)]
    public class TkAnimStateMachineTransitionData : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public List<NMSTemplate> Conditions;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 DestinationStateDebugName;
        [NMS(Index = 6)]
        /* 0x20 */ public TkAnimBlendType BlendType;
        [NMS(Index = 0)]
        /* 0x24 */ public int DestinationState;
        [NMS(Index = 3)]
        /* 0x28 */ public float ExitTime;
        [NMS(Index = 4)]
        /* 0x2C */ public float TransitionTime;
        [NMS(Index = 5)]
        /* 0x30 */ public TkAnimStateMachineBlendTimeMode TransitionTimeMode;
        [NMS(Index = 2)]
        /* 0x34 */ public bool HasTimedExit;
    }
}
