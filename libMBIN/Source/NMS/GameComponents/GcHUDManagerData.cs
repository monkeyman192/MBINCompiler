using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x205BFEB3B8061079, NameHash = 0x756972574B9CCB08)]
    public class GcHUDManagerData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcTextPreset SubtitleFont;
        [NMS(Index = 2)]
        /* 0x070 */ public GcTextPreset SubtitleFontSmall;
        [NMS(Index = 0)]
        /* 0x0E0 */ public GcTextPreset TitleFont;
        [NMS(Index = 28)]
        /* 0x150 */ public int ModelRenderDisplayBorder;
        [NMS(Index = 30)]
        /* 0x154 */ public float ModelRenderDisplayMove;
        [NMS(Index = 29)]
        /* 0x158 */ public float ModelRenderDisplayOffset;
        [NMS(Index = 27)]
        /* 0x15C */ public int ModelRenderDisplaySize;
        [NMS(Index = 26)]
        /* 0x160 */ public int ModelRenderTextureSize;
        [NMS(Index = 7)]
        /* 0x164 */ public float OSDBaseBandY;
        [NMS(Index = 6)]
        /* 0x168 */ public float OSDBaseTextY;
        [NMS(Index = 8)]
        /* 0x16C */ public float OSDBorderY;
        [NMS(Index = 5)]
        /* 0x170 */ public float OSDCoreAlpha;
        [NMS(Index = 3)]
        /* 0x174 */ public float OSDCoreSize;
        [NMS(Index = 16)]
        /* 0x178 */ public float OSDEdgeMergeAlpha;
        [NMS(Index = 15)]
        /* 0x17C */ public float OSDFadeSpeed;
        [NMS(Index = 4)]
        /* 0x180 */ public float OSDFullSize;
        [NMS(Index = 17)]
        /* 0x184 */ public float OSDTextAppearRate;
        [NMS(Index = 18)]
        /* 0x188 */ public float OSDTextFadeRate;
        [NMS(Index = 19)]
        /* 0x18C */ public float OSDTextWaitOnAlpha;
        [NMS(Index = 9)]
        /* 0x190 */ public float OSDUnderlineWidth;
        [NMS(Index = 21)]
        /* 0x194 */ public float PopUpBGFadeInRate;
        [NMS(Index = 22)]
        /* 0x198 */ public float PopUpBGFadeOutRate;
        [NMS(Index = 23)]
        /* 0x19C */ public float PopUpBGTriggerFG;
        [NMS(Index = 12)]
        /* 0x1A0 */ public float PopUpCoreAlpha;
        [NMS(Index = 10)]
        /* 0x1A4 */ public float PopUpCoreSize;
        [NMS(Index = 20)]
        /* 0x1A8 */ public float PopUpFadeRate;
        [NMS(Index = 11)]
        /* 0x1AC */ public float PopUpFullSize;
        [NMS(Index = 13)]
        /* 0x1B0 */ public float PopUpY;
        [NMS(Index = 14)]
        /* 0x1B4 */ public float PopUpYMidLock;
        [NMS(Index = 24)]
        /* 0x1B8 */ public float PromptLine1Y;
        [NMS(Index = 25)]
        /* 0x1BC */ public float PromptLine2Y;
        [NMS(Index = 31)]
        /* 0x1C0 */ public TkCurveType ModelRenderDisplayAlphaCurve;
        [NMS(Index = 32)]
        /* 0x1C1 */ public TkCurveType ModelRenderDisplayMoveCurve;
    }
}
