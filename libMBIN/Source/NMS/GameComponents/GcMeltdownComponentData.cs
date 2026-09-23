using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x537B5C780C05F15D, NameHash = 0x993C48D6)]
    public class GcMeltdownComponentData : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x00 */ public NMSString0x20A WarningMessage;
        [NMS(Index = 11)]
        /* 0x20 */ public NMSString0x10 AreaDamage;
        [NMS(Index = 10)]
        /* 0x30 */ public List<NMSString0x10> BlockingMissionIds;
        [NMS(Index = 0)]
        /* 0x40 */ public float Duration;
        [NMS(Index = 1)]
        /* 0x44 */ public float DurationRandomAddition;
        [NMS(Index = 3)]
        /* 0x48 */ public float MaxArcingDelay;
        [NMS(Index = 5)]
        /* 0x4C */ public float MaxExplosionDelay;
        [NMS(Index = 14)]
        /* 0x50 */ public GcAudioWwiseEvents MeltdownAlarmAudio;
        [NMS(Index = 8)]
        /* 0x54 */ public float MeltdownMaxRoll;
        [NMS(Index = 7)]
        /* 0x58 */ public float MeltdownMinRoll;
        [NMS(Index = 13)]
        /* 0x5C */ public GcAudioWwiseEvents MeltdownStartAudio;
        [NMS(Index = 2)]
        /* 0x60 */ public float MinArcingDelay;
        [NMS(Index = 4)]
        /* 0x64 */ public float MinExplosionDelay;
        [NMS(Index = 6)]
        /* 0x68 */ public float PressureDecayRate;
        [NMS(Index = 9)]
        /* 0x6C */ public float WarningRadius;
        [NMS(Index = 17)]
        /* 0x70 */ public NMSString0x20 ArcNodeName;
        [NMS(Index = 18)]
        /* 0x90 */ public NMSString0x20 ExplosionNodeName;
        [NMS(Index = 15)]
        /* 0xB0 */ public NMSString0x20 FlashLightNodeName;
        [NMS(Index = 16)]
        /* 0xD0 */ public NMSString0x20 SpinLightNodeName;
    }
}
