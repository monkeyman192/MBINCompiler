using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x18C90AC3ABEDC7CD, NameHash = 0x756972574B9CCB08)]
    public class GcHUDManagerData : NMSTemplate
    {
        public GcTextPreset TitleFont;
        public GcTextPreset SubtitleFont;
        public GcTextPreset SubtitleFontSmall;

        public float OSDCoreSize;
        public float OSDFullSize;
        public float OSDCoreAlpha;
        public float OSDBaseTextY;
        public float OSDBaseBandY;
        public float OSDBorderY;
        public float OSDUnderlineWidth;
        public float PopUpCoreSize;
        public float PopUpFullSize;
        public float PopUpCoreAlpha;
        public float PopUpY;
        public float PopUpYMidLock;
        public float OSDFadeSpeed;
        public float OSDEdgeMergeAlpha;
        public float OSDTextAppearRate;
        public float OSDTextFadeRate;
        public float OSDTextWaitOnAlpha;
        public float PopUpFadeRate;
        public float PopUpBGFadeInRate;
        public float PopUpBGFadeOutRate;
        public float PopUpBGTriggerFG;
        public float PromptLine1Y;
        public float PromptLine2Y;
        public int ModelRenderTextureSize;
        public int ModelRenderDisplaySize;
        public int ModelRenderDisplayBorder;
        public float ModelRenderDisplayOffset;
        public float ModelRenderDisplayMove;
        public TkCurveType ModelRenderDisplayAlphaCurve;
        public TkCurveType ModelRenderDisplayMoveCurve;

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding1C8;
    }
}
