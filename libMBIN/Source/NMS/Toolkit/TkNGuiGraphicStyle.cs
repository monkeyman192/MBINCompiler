using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBCBE1C90ABE771C2, NameHash = 0xB70875CDF93EECEC)]
    public class TkNGuiGraphicStyle : NMSTemplate
    {
        /* 0x000 */ public TkNGuiGraphicStyleData Default;
        /* 0x0A0 */ public TkNGuiGraphicStyleData Highlight;
        /* 0x140 */ public TkNGuiGraphicStyleData Active;
        /* 0x1E0 */ public bool InheritStyleFromParentLayer;
        /* 0x1E4 */ public float HighlightTime;
        /* 0x1E8 */ public float HighlightScale;
        /* 0x1EC */ public float GlobalFade;
        // size: 0x6
        public enum AnimateEnum {
            None,
            WipeRightToLeft,
            SimpleWipe,
            SimpleWipeDown,
            CustomWipe,
            CustomWipeAlpha
        }
        /* 0x1F0 */ public AnimateEnum Animate;
        /* 0x1F4 */ public float AnimTime;
        /* 0x1F8 */ public float AnimSplit;
        /* 0x1FC */ public TkCurveType AnimCurve1;
        /* 0x200 */ public TkCurveType AnimCurve2;
        /* 0x204 */ public Vector2f CustomMinStart;
        /* 0x20C */ public Vector2f CustomMaxStart;
    }
}
