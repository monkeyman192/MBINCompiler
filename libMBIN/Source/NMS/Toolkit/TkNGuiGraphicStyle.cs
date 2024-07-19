using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE1DBB4B3A913A72A, NameHash = 0x80EBCD8A)]
    public class TkNGuiGraphicStyle : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public TkNGuiGraphicStyleData Active;
        [NMS(Index = 0)]
        /* 0x0A0 */ public TkNGuiGraphicStyleData Default;
        [NMS(Index = 1)]
        /* 0x140 */ public TkNGuiGraphicStyleData Highlight;
        [NMS(Index = 13)]
        /* 0x1E0 */ public Vector2f CustomMaxStart;
        [NMS(Index = 12)]
        /* 0x1E8 */ public Vector2f CustomMinStart;
        // size: 0x6
        public enum AnimateEnum : uint {
            None,
            WipeRightToLeft,
            SimpleWipe,
            SimpleWipeDown,
            CustomWipe,
            CustomWipeAlpha,
        }
        [NMS(Index = 7)]
        /* 0x1F0 */ public AnimateEnum Animate;
        [NMS(Index = 9)]
        /* 0x1F4 */ public float AnimSplit;
        [NMS(Index = 8)]
        /* 0x1F8 */ public float AnimTime;
        [NMS(Index = 6)]
        /* 0x1FC */ public float GlobalFade;
        [NMS(Index = 5)]
        /* 0x200 */ public float HighlightScale;
        [NMS(Index = 4)]
        /* 0x204 */ public float HighlightTime;
        [NMS(Index = 10)]
        /* 0x208 */ public TkCurveType AnimCurve1;
        [NMS(Index = 11)]
        /* 0x209 */ public TkCurveType AnimCurve2;
        [NMS(Index = 3)]
        /* 0x20A */ public bool InheritStyleFromParentLayer;
    }
}
