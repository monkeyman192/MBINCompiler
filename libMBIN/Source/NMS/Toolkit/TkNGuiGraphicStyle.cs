using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x14961F4B4436B554, NameHash = 0xB70875CDF93EECEC)]
    public class TkNGuiGraphicStyle : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public TkNGuiGraphicStyleData Active;
        [NMS(Index = 0)]
        /* 0x090 */ public TkNGuiGraphicStyleData Default;
        [NMS(Index = 1)]
        /* 0x120 */ public TkNGuiGraphicStyleData Highlight;
        [NMS(Index = 4)]
        /* 0x1B0 */ public Vector2f CustomMaxStart;
        [NMS(Index = 3)]
        /* 0x1B8 */ public Vector2f CustomMinStart;
        [NMS(Index = 9)]
        /* 0x1C0 */ public float AnimSplit;
        [NMS(Index = 8)]
        /* 0x1C4 */ public float AnimTime;
        [NMS(Index = 7)]
        /* 0x1C8 */ public float GlobalFade;
        [NMS(Index = 6)]
        /* 0x1CC */ public float HighlightScale;
        [NMS(Index = 5)]
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
        [NMS(Index = 12)]
        /* 0x1D4 */ public AnimateEnum Animate;
        [NMS(Index = 10)]
        /* 0x1D5 */ public TkCurveType AnimCurve1;
        [NMS(Index = 11)]
        /* 0x1D6 */ public TkCurveType AnimCurve2;
        [NMS(Index = 13)]
        /* 0x1D7 */ public bool InheritStyleFromParentLayer;
    }
}
