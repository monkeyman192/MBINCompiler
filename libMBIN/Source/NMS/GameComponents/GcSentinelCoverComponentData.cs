using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4EAD1F33EAED6BC9, NameHash = 0xE1F35851383555E2)]
    public class GcSentinelCoverComponentData : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcSentinelCoverState.SentinelCoverStateEnum))]
        /* 0x00 */ public NMSString0x10[] CoverStateAnims;
        /* 0x40 */ public NMSString0x10 DestroyEffectId;
        /* 0x50 */ public NMSString0x10 SpawnEffectId;
        /* 0x60 */ public float HealthPercLostPerSecMax;
        /* 0x64 */ public float HealthPercLostPerSecMin;
        /* 0x68 */ public NMSString0x20 EffectLocator;
    }
}
