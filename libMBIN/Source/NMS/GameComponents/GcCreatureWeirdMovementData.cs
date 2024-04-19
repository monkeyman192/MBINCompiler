using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE92FCC2DF81C6C7D, NameHash = 0xBE42E310FC94C8E3)]
    public class GcCreatureWeirdMovementData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x100> FeetNames;
        /* 0x10 */ public float BobAmount;
        /* 0x14 */ public float BobSpeed;
        /* 0x18 */ public float JumpAngle;
        // size: 0x3
        public enum MoveModeEnum : uint {
            Roll,
            Float,
            Drill,
        }
        /* 0x1C */ public MoveModeEnum MoveMode;
        /* 0x20 */ public float SpinSpeed;
        /* 0x24 */ public NMSString0x100 Node;
    }
}
