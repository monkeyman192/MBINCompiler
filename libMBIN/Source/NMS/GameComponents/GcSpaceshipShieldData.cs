namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC082DA22F31ABFD8, NameHash = 0x715B2B315094E969)]
    public class GcSpaceshipShieldData : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public NMSString0x10 DamageMulOverride;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x20 */ public int Health;
        [NMS(Index = 2)]
        /* 0x24 */ public int LevelledExtraHealth;
        [NMS(Index = 4)]
        /* 0x28 */ public float RechargeDelayTime;
        [NMS(Index = 3)]
        /* 0x2C */ public float RechargeTime;
        [NMS(Index = 5)]
        /* 0x30 */ public bool StartDepletedWhenEnabled;
    }
}
