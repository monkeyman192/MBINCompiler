using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1EF6B898301EEBD5, NameHash = 0x24B6E7D6F92704D5)]
    public class GcShipHUDTargetData : NMSTemplate
    {
        /* 0x000 */ public Colour BaseColour;
        /* 0x010 */ public Colour LockColour;
        /* 0x020 */ public Colour PoliceColour1;
        /* 0x030 */ public Colour PoliceColour2;
        /* 0x040 */ public Colour ThreatColour;
        /* 0x050 */ public float ActivateTime;
        /* 0x054 */ public float ActiveDistance;
        /* 0x058 */ public float ArrowFadeRange;
        /* 0x05C */ public float ArrowMaxSize;
        /* 0x060 */ public float ArrowMinFadeDist;
        /* 0x064 */ public float ArrowMinSize;
        /* 0x068 */ public float ArrowOffset;
        /* 0x06C */ public float ArrowScale;
        /* 0x070 */ public float GlowAlpha;
        /* 0x074 */ public float HighlightTime;
        /* 0x078 */ public float HitPulse;
        /* 0x07C */ public float HitPulseTime;
        /* 0x080 */ public float HitWhiteOut;
        /* 0x084 */ public float IconMaxSize;
        /* 0x088 */ public float IconMinSize;
        /* 0x08C */ public float IconSizeIn;
        /* 0x090 */ public float IconSizeScale;
        /* 0x094 */ public float PoliceColourFreq;
        /* 0x098 */ public GcShipHUDTargetIconData IconData;
        /* 0x398 */ public NMSString0x80 Arrow;
    }
}
