namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x1B0)]
    public class TkNGuiGraphicStyle : NMSTemplate
    {
        /* 0x000 */ public TkNGuiGraphicStyleData Default;
        /* 0x080 */ public TkNGuiGraphicStyleData Highlight;
        /* 0x100 */ public TkNGuiGraphicStyleData Active;
        /* 0x180 */ public float HighlightTime;
        /* 0x184 */ public float HighlightScale;
        /* 0x188 */ public float GlobalFade;
		public enum AnimateEnum { None, WipeRightToLeft, SimpleWipe, SimpleWipeDown, CustomWipe, CustomWipeAlpha }
		public AnimateEnum Animate;
        /* 0x190 */ public float AnimTime;
        /* 0x194 */ public float AnimSplit;
        /* 0x198 */ public TkCurveType AnimCurve1;
        /* 0x19C */ public TkCurveType AnimCurve2;

        /* 0x1A0 */ public Vector2f CustomMinStart;
        /* 0x1A8 */ public Vector2f CustomMaxStart;
    }
}
