using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF208518170F7956C, NameHash = 0xBE42E310FC94C8E3)]
    public class GcCreatureWeirdMovementData : NMSTemplate
    {
        public enum MoveModeEnum { Roll, Float, Drill }
        /* 0x000 */ public MoveModeEnum MoveMode;
        /* 0x004 */ public NMSString0x100 Node;
        /* 0x104 */ public float BobSpeed;
        /* 0x108 */ public float BobAmount;
        /* 0x10C */ public float SpinSpeed;
        /* 0x110 */ public float JumpAngle;
        /* 0x118 */ public List<NMSString0x100> FeetNames;
    }
}
