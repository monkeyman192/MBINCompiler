using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFAAE0E8D04CC6DAE, NameHash = 0x5323BBD4)]
    public class GcCreatureWeirdMovementData : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public List<NMSString0x100> FeetNames;
        [NMS(Index = 3)]
        /* 0x10 */ public float BobAmount;
        [NMS(Index = 2)]
        /* 0x14 */ public float BobSpeed;
        [NMS(Index = 5)]
        /* 0x18 */ public float JumpAngle;
        // size: 0x3
        public enum MoveModeEnum : uint {
            Roll,
            Float,
            Drill,
        }
        [NMS(Index = 0)]
        /* 0x1C */ public MoveModeEnum MoveMode;
        [NMS(Index = 4)]
        /* 0x20 */ public float SpinSpeed;
        [NMS(Index = 1)]
        /* 0x24 */ public NMSString0x100 Node;
    }
}
