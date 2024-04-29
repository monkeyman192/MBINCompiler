namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xADAB9109B86CBB8E, NameHash = 0xD3C00A838E2E66D6)]
    public class GcSentinelDamagedData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 DamageEffect;
        [NMS(Index = 7)]
        /* 0x10 */ public NMSString0x10 DamageType;
        [NMS(Index = 4)]
        /* 0x20 */ public NMSString0x10 SelfDestructEffect;
        [NMS(Index = 1)]
        /* 0x30 */ public float DamageEffectHealthPercentThreshold;
        [NMS(Index = 5)]
        /* 0x34 */ public float RangeTrigger;
        [NMS(Index = 6)]
        /* 0x38 */ public float TimeTrigger;
        [NMS(Index = 3)]
        /* 0x3C */ public bool CanSelfDestruct;
        [NMS(Index = 0)]
        /* 0x3D */ public bool UseDamageEffect;
    }
}
