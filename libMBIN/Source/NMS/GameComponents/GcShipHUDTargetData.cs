using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x430, GUID = 0xEBA3C048EB64D94A, NameHash = 0x24B6E7D6F92704D5)]
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

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding3A8;

        public Colour BaseColour;

        public float ActiveDistance;
        public float ActivateTime;

        public float GlowAlpha;

        public float HighlightTime;

        public float HitPulse;
        public float HitPulseTime;
        public float HitWhiteOut;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding3DC;

        public Colour LockColour;

        public float PoliceColourFreq;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding3F4;

        public Colour PoliceColour1;
        public Colour PoliceColour2;

        public Colour ThreatColour;
    }
}
