using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA8C9D6F6CC0F3428, NameHash = 0xE1F35851383555E2)]
    public class GcSentinelCoverComponentData : NMSTemplate
    {
        [NMS(Index = 5, Size = 0x4, EnumType = typeof(GcSentinelCoverState.SentinelCoverStateEnum))]
        /* 0x00 */ public NMSString0x10[] CoverStateAnims;
        [NMS(Index = 3)]
        /* 0x40 */ public NMSString0x10 DestroyEffectId;
        [NMS(Index = 2)]
        /* 0x50 */ public NMSString0x10 SpawnEffectId;
        [NMS(Index = 1)]
        /* 0x60 */ public float HealthPercLostPerSecMax;
        [NMS(Index = 0)]
        /* 0x64 */ public float HealthPercLostPerSecMin;
        [NMS(Index = 4)]
        /* 0x68 */ public NMSString0x20 EffectLocator;
    }
}
