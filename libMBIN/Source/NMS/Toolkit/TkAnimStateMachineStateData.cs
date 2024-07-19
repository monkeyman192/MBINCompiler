using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x73DB08F42E4001D1, NameHash = 0xAD0019B)]
    public class TkAnimStateMachineStateData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A Anim;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Name;
        [NMS(Index = 8)]
        /* 0x30 */ public List<TkAnimStateMachineTransitionData> Transitions;
        [NMS(Index = 1)]
        /* 0x40 */ public int Id;
        [NMS(Index = 3)]
        /* 0x44 */ public int NodePosX;
        [NMS(Index = 4)]
        /* 0x48 */ public int NodePosY;
        [NMS(Index = 5)]
        /* 0x4C */ public float ScrollX;
        [NMS(Index = 6)]
        /* 0x50 */ public float ScrollY;
        [NMS(Index = 7)]
        /* 0x54 */ public float Zoom;
    }
}
