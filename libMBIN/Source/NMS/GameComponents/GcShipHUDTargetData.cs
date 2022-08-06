using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xEBA3C048EB64D94A, NameHash = 0x24B6E7D6F92704D5)]
    public class GcShipHUDTargetData : NMSTemplate
    {
        public GcShipHUDTargetIconData IconData;

        public NMSString0x80 Arrow;

        public float IconSizeIn;
        public float IconMinSize;
        public float IconMaxSize;
        public float IconSizeScale;

        public float ArrowScale;
        public float ArrowOffset;
        public float ArrowMinFadeDist;
        public float ArrowFadeRange;
        public float ArrowMinSize;
        public float ArrowMaxSize;

        public Colour BaseColour;

        public float ActiveDistance;
        public float ActivateTime;

        public float GlowAlpha;

        public float HighlightTime;

        public float HitPulse;
        public float HitPulseTime;
        public float HitWhiteOut;

        public Colour LockColour;

        public float PoliceColourFreq;

        public Colour PoliceColour1;
        public Colour PoliceColour2;

        public Colour ThreatColour;
    }
}
