using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x603007F5DACD5DC3, NameHash = 0x24B6E7D6F92704D5)]
    public class GcShipHUDTargetData : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x000 */ public Colour BaseColour;
        [NMS(Index = 20)]
        /* 0x010 */ public Colour LockColour;
        [NMS(Index = 22)]
        /* 0x020 */ public Colour PoliceColour1;
        [NMS(Index = 23)]
        /* 0x030 */ public Colour PoliceColour2;
        [NMS(Index = 24)]
        /* 0x040 */ public Colour ThreatColour;
        [NMS(Index = 14)]
        /* 0x050 */ public float ActivateTime;
        [NMS(Index = 13)]
        /* 0x054 */ public float ActiveDistance;
        [NMS(Index = 9)]
        /* 0x058 */ public float ArrowFadeRange;
        [NMS(Index = 11)]
        /* 0x05C */ public float ArrowMaxSize;
        [NMS(Index = 8)]
        /* 0x060 */ public float ArrowMinFadeDist;
        [NMS(Index = 10)]
        /* 0x064 */ public float ArrowMinSize;
        [NMS(Index = 7)]
        /* 0x068 */ public float ArrowOffset;
        [NMS(Index = 6)]
        /* 0x06C */ public float ArrowScale;
        [NMS(Index = 15)]
        /* 0x070 */ public float GlowAlpha;
        [NMS(Index = 16)]
        /* 0x074 */ public float HighlightTime;
        [NMS(Index = 17)]
        /* 0x078 */ public float HitPulse;
        [NMS(Index = 18)]
        /* 0x07C */ public float HitPulseTime;
        [NMS(Index = 19)]
        /* 0x080 */ public float HitWhiteOut;
        [NMS(Index = 4)]
        /* 0x084 */ public float IconMaxSize;
        [NMS(Index = 3)]
        /* 0x088 */ public float IconMinSize;
        [NMS(Index = 2)]
        /* 0x08C */ public float IconSizeIn;
        [NMS(Index = 5)]
        /* 0x090 */ public float IconSizeScale;
        [NMS(Index = 21)]
        /* 0x094 */ public float PoliceColourFreq;
        [NMS(Index = 0)]
        /* 0x098 */ public GcShipHUDTargetIconData IconData;
        [NMS(Index = 1)]
        /* 0x398 */ public NMSString0x80 Arrow;
    }
}
