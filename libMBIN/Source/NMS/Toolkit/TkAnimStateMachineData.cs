using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x895BB7BFAF3B0445, NameHash = 0x30C6F48D)]
    public class TkAnimStateMachineData : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public List<TkAnimStateMachineTransitionData> EntryTransitions;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSString0x10 LayerId;
        [NMS(Index = 8)]
        /* 0x20 */ public List<TkAnimStateMachineStateData> States;
        [NMS(Index = 6)]
        /* 0x30 */ public int DefaultState;
        [NMS(Index = 4)]
        /* 0x34 */ public int EntryPosX;
        [NMS(Index = 5)]
        /* 0x38 */ public int EntryPosY;
        [NMS(Index = 0)]
        /* 0x3C */ public float ScrollX;
        [NMS(Index = 1)]
        /* 0x40 */ public float ScrollY;
        [NMS(Index = 2)]
        /* 0x44 */ public float Zoom;
    }
}
