using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0xF2A6C64121B1D193, NameHash = 0xAAC69095D4C233F5)]
    public class GcRobotLaserData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 LaserID;
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