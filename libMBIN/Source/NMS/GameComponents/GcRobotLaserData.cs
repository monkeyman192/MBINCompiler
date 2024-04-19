namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3588D6B453B06BE1, NameHash = 0xAAC69095D4C233F5)]
    public class GcRobotLaserData : NMSTemplate
    {
        /* 0x00 */ public Colour LaserColour;
        /* 0x10 */ public Vector3f LaserLightOffset;
        /* 0x20 */ public NMSString0x10 LaserID;
        /* 0x30 */ public float LaserActiveSpringTime;
        /* 0x34 */ public float LaserChargeTime;
        /* 0x38 */ public float LaserLightAttackSize;
        /* 0x3C */ public float LaserLightChargeSize;
        /* 0x40 */ public int LaserMiningDamage;
        /* 0x44 */ public float LaserSpringTime;
        /* 0x48 */ public float LaserTime;
    }
}
