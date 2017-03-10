using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcRobotLaserBeamData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string LaserID;
        /* 0x10 */ public float LaserSpringTime;
        /* 0x14 */ public float LaserActiveSpringTime;
        /* 0x18 */ public int LaserMiningDamage;
        /* 0x1C */ public float LaserChargeTime;
        /* 0x20 */ public float LaserTime;
        /* 0x24 */ public float LaserLightChargeSize;
        /* 0x28 */ public float LaserLightAttackSize;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2C */ public byte[] pad2C;
        /* 0x30 */ public Vector4f LaserLightOffset;
        /* 0x40 */ public Colour LaserColour;
    }

}
