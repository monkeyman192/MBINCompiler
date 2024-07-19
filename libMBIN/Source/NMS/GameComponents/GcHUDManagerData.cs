using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5122E004D00CCCB8, NameHash = 0x9F4CDEBC)]
    public class GcHUDManagerData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcTextPreset SubtitleFont;
        [NMS(Index = 2)]
        /* 0x030 */ public GcTextPreset SubtitleFontSmall;
        [NMS(Index = 0)]
        /* 0x060 */ public GcTextPreset TitleFont;
        [NMS(Index = 28)]
        /* 0x090 */ public int ModelRenderDisplayBorder;
        [NMS(Index = 30)]
        /* 0x094 */ public float ModelRenderDisplayMove;
        [NMS(Index = 29)]
        /* 0x098 */ public float ModelRenderDisplayOffset;
        [NMS(Index = 27)]
        /* 0x09C */ public int ModelRenderDisplaySize;
        [NMS(Index = 26)]
        /* 0x0A0 */ public int ModelRenderTextureSize;
        [NMS(Index = 7)]
        /* 0x0A4 */ public float OSDBaseBandY;
        [NMS(Index = 6)]
        /* 0x0A8 */ public float OSDBaseTextY;
        [NMS(Index = 8)]
        /* 0x0AC */ public float OSDBorderY;
        [NMS(Index = 5)]
        /* 0x0B0 */ public float OSDCoreAlpha;
        [NMS(Index = 3)]
        /* 0x0B4 */ public float OSDCoreSize;
        [NMS(Index = 16)]
        /* 0x0B8 */ public float OSDEdgeMergeAlpha;
        [NMS(Index = 15)]
        /* 0x0BC */ public float OSDFadeSpeed;
        [NMS(Index = 4)]
        /* 0x0C0 */ public float OSDFullSize;
        [NMS(Index = 17)]
        /* 0x0C4 */ public float OSDTextAppearRate;
        [NMS(Index = 18)]
        /* 0x0C8 */ public float OSDTextFadeRate;
        [NMS(Index = 19)]
        /* 0x0CC */ public float OSDTextWaitOnAlpha;
        [NMS(Index = 9)]
        /* 0x0D0 */ public float OSDUnderlineWidth;
        [NMS(Index = 21)]
        /* 0x0D4 */ public float PopUpBGFadeInRate;
        [NMS(Index = 22)]
        /* 0x0D8 */ public float PopUpBGFadeOutRate;
        [NMS(Index = 23)]
        /* 0x0DC */ public float PopUpBGTriggerFG;
        [NMS(Index = 12)]
        /* 0x0E0 */ public float PopUpCoreAlpha;
        [NMS(Index = 10)]
        /* 0x0E4 */ public float PopUpCoreSize;
        [NMS(Index = 20)]
        /* 0x0E8 */ public float PopUpFadeRate;
        [NMS(Index = 11)]
        /* 0x0EC */ public float PopUpFullSize;
        [NMS(Index = 13)]
        /* 0x0F0 */ public float PopUpY;
        [NMS(Index = 14)]
        /* 0x0F4 */ public float PopUpYMidLock;
        [NMS(Index = 24)]
        /* 0x0F8 */ public float PromptLine1Y;
        [NMS(Index = 25)]
        /* 0x0FC */ public float PromptLine2Y;
        [NMS(Index = 31)]
        /* 0x100 */ public TkCurveType ModelRenderDisplayAlphaCurve;
        [NMS(Index = 32)]
        /* 0x101 */ public TkCurveType ModelRenderDisplayMoveCurve;
    }
}
