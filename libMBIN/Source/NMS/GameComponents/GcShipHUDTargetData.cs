using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEF43D224C684762A, NameHash = 0x626EFF)]
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
        [NMS(Index = 0)]
        /* 0x050 */ public GcShipHUDTargetIconData IconData;
        [NMS(Index = 1)]
        /* 0x0B0 */ public VariableSizeString Arrow;
        [NMS(Index = 14)]
        /* 0x0C0 */ public float ActivateTime;
        [NMS(Index = 13)]
        /* 0x0C4 */ public float ActiveDistance;
        [NMS(Index = 9)]
        /* 0x0C8 */ public float ArrowFadeRange;
        [NMS(Index = 11)]
        /* 0x0CC */ public float ArrowMaxSize;
        [NMS(Index = 8)]
        /* 0x0D0 */ public float ArrowMinFadeDist;
        [NMS(Index = 10)]
        /* 0x0D4 */ public float ArrowMinSize;
        [NMS(Index = 7)]
        /* 0x0D8 */ public float ArrowOffset;
        [NMS(Index = 6)]
        /* 0x0DC */ public float ArrowScale;
        [NMS(Index = 15)]
        /* 0x0E0 */ public float GlowAlpha;
        [NMS(Index = 16)]
        /* 0x0E4 */ public float HighlightTime;
        [NMS(Index = 17)]
        /* 0x0E8 */ public float HitPulse;
        [NMS(Index = 18)]
        /* 0x0EC */ public float HitPulseTime;
        [NMS(Index = 19)]
        /* 0x0F0 */ public float HitWhiteOut;
        [NMS(Index = 4)]
        /* 0x0F4 */ public float IconMaxSize;
        [NMS(Index = 3)]
        /* 0x0F8 */ public float IconMinSize;
        [NMS(Index = 2)]
        /* 0x0FC */ public float IconSizeIn;
        [NMS(Index = 5)]
        /* 0x100 */ public float IconSizeScale;
        [NMS(Index = 21)]
        /* 0x104 */ public float PoliceColourFreq;
    }
}
