using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA5887A75CC7DCCF1, NameHash = 0x993C48D6)]
    public class GcMeltdownComponentData : NMSTemplate
    {
        [NMS(Index = 11)]
        /* 0x00 */ public NMSString0x20A WarningMessage;
        [NMS(Index = 10)]
        /* 0x20 */ public NMSString0x10 AreaDamage;
        [NMS(Index = 0)]
        /* 0x30 */ public float Duration;
        [NMS(Index = 1)]
        /* 0x34 */ public float DurationRandomAddition;
        [NMS(Index = 3)]
        /* 0x38 */ public float MaxArcingDelay;
        [NMS(Index = 5)]
        /* 0x3C */ public float MaxExplosionDelay;
        [NMS(Index = 13)]
        /* 0x40 */ public GcAudioWwiseEvents MeltdownAlarmAudio;
        [NMS(Index = 8)]
        /* 0x44 */ public float MeltdownMaxRoll;
        [NMS(Index = 7)]
        /* 0x48 */ public float MeltdownMinRoll;
        [NMS(Index = 12)]
        /* 0x4C */ public GcAudioWwiseEvents MeltdownStartAudio;
        [NMS(Index = 2)]
        /* 0x50 */ public float MinArcingDelay;
        [NMS(Index = 4)]
        /* 0x54 */ public float MinExplosionDelay;
        [NMS(Index = 6)]
        /* 0x58 */ public float PressureDecayRate;
        [NMS(Index = 9)]
        /* 0x5C */ public float WarningRadius;
        [NMS(Index = 16)]
        /* 0x60 */ public NMSString0x20 ArcNodeName;
        [NMS(Index = 17)]
        /* 0x80 */ public NMSString0x20 ExplosionNodeName;
        [NMS(Index = 14)]
        /* 0xA0 */ public NMSString0x20 FlashLightNodeName;
        [NMS(Index = 15)]
        /* 0xC0 */ public NMSString0x20 SpinLightNodeName;
    }
}
