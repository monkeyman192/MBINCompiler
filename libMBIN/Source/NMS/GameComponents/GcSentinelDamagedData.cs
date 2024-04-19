namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA206721F6430150F, NameHash = 0xD3C00A838E2E66D6)]
    public class GcSentinelDamagedData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 DamageEffect;
        /* 0x10 */ public NMSString0x10 DamageType;
        /* 0x20 */ public NMSString0x10 SelfDestructEffect;
        /* 0x30 */ public float DamageEffectHealthPercentThreshold;
        /* 0x34 */ public float RangeTrigger;
        /* 0x38 */ public float TimeTrigger;
        /* 0x3C */ public bool CanSelfDestruct;
        /* 0x3D */ public bool UseDamageEffect;
    }
}
