using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x210, GUID = 0x5B98CE75F0CD3F94, Alignment = 0x10, NameHash = 0xB70875CDF93EECEC)]
    public class TkNGuiGraphicStyle : NMSTemplate
    {
        /* 0x000 */ public TkNGuiGraphicStyleData Default;
        /* 0x0A0 */ public TkNGuiGraphicStyleData Highlight;
        /* 0x140 */ public TkNGuiGraphicStyleData Active;
        /* 0x1E0 */ public float HighlightTime;
        /* 0x1E4 */ public float HighlightScale;
        /* 0x1E8 */ public float GlobalFade;
		public enum AnimateEnum { None, WipeRightToLeft, SimpleWipe, SimpleWipeDown, CustomWipe, CustomWipeAlpha }
		/* 0x1EC */ public AnimateEnum Animate;
        /* 0x1F0 */ public float AnimTime;
        /* 0x1F4 */ public float AnimSplit;
        /* 0x1F8 */ public TkCurveType AnimCurve1;
        /* 0x1FC */ public TkCurveType AnimCurve2;
        /* 0x200 */ public Vector2f CustomMinStart;
        /* 0x208 */ public Vector2f CustomMaxStart;
    }
}
