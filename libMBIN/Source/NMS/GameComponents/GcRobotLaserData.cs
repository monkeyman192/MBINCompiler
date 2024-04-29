namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7792A2B4AFBA00FB, NameHash = 0xAAC69095D4C233F5)]
    public class GcRobotLaserData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public Colour LaserColour;
        [NMS(Index = 8)]
        /* 0x10 */ public Vector3f LaserLightOffset;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 LaserID;
        [NMS(Index = 2)]
        /* 0x30 */ public float LaserActiveSpringTime;
        [NMS(Index = 4)]
        /* 0x34 */ public float LaserChargeTime;
        [NMS(Index = 7)]
        /* 0x38 */ public float LaserLightAttackSize;
        [NMS(Index = 6)]
        /* 0x3C */ public float LaserLightChargeSize;
        [NMS(Index = 3)]
        /* 0x40 */ public int LaserMiningDamage;
        [NMS(Index = 1)]
        /* 0x44 */ public float LaserSpringTime;
        [NMS(Index = 5)]
        /* 0x48 */ public float LaserTime;
    }
}
