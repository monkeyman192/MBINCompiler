using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x14961F4B4436B554, NameHash = 0xB70875CDF93EECEC)]
    public class TkNGuiGraphicStyle : NMSTemplate
    {
        /* 0x000 */ public TkNGuiGraphicStyleData Active;
        /* 0x090 */ public TkNGuiGraphicStyleData Default;
        /* 0x120 */ public TkNGuiGraphicStyleData Highlight;
        /* 0x1B0 */ public Vector2f CustomMaxStart;
        /* 0x1B8 */ public Vector2f CustomMinStart;
        /* 0x1C0 */ public float AnimSplit;
        /* 0x1C4 */ public float AnimTime;
        /* 0x1C8 */ public float GlobalFade;
        /* 0x1CC */ public float HighlightScale;
        /* 0x1D0 */ public float HighlightTime;
        // size: 0x6
        public enum AnimateEnum : byte {
            None,
            WipeRightToLeft,
            SimpleWipe,
            SimpleWipeDown,
            CustomWipe,
            CustomWipeAlpha,
        }
        /* 0x1D4 */ public AnimateEnum Animate;
        /* 0x1D5 */ public TkCurveType AnimCurve1;
        /* 0x1D6 */ public TkCurveType AnimCurve2;
        /* 0x1D7 */ public bool InheritStyleFromParentLayer;
    }
}
