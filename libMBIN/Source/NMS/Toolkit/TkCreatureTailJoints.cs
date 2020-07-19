using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x54, GUID = 0x982B54282AC0592, NameHash = 0x38D7F8085AD4CE3)]
    public class TkCreatureTailJoints : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string StartJoint;
        [NMS(Size = 0x20)]
        /* 0x20 */ public string EndJoint;
        /* 0x40 */ public float InterpSpeedHead;
        /* 0x44 */ public float InterpSpeedTail;
        /* 0x48 */ public float StrengthX;
        /* 0x4C */ public float StrengthY;
        /* 0x50 */ public float StrengthZ;
    }
}