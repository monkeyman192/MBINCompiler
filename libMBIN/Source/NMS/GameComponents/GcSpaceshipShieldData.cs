namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC83EB958EC113295, NameHash = 0x715B2B315094E969)]
    public class GcSpaceshipShieldData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 DamageMulOverride;
        /* 0x10 */ public NMSString0x10 Id;
        /* 0x20 */ public int Health;
        /* 0x24 */ public int LevelledExtraHealth;
        /* 0x28 */ public float RechargeDelayTime;
        /* 0x2C */ public float RechargeTime;
        /* 0x30 */ public bool StartDepletedWhenEnabled;
    }
}
