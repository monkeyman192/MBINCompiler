using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x550, GUID = 0x68F5A0AE90CF2CB7, NameHash = 0x6F26BF19981BB60C)]
    public class TkNGuiEditorStyleData : NMSTemplate
    {
        /* 0x000 */ public List<float> Sizes;

        [NMS(Size = 8)]
        /* 0x010 */ public TkNGuiEditorStyleColour[] SkinColours;

        /* 0x490 */ public float SkinFontHeight;

        [NMS(Size = 0x80)]
        /* 0x494 */ public string Font;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x514 */ public byte[] Padding514;
        /* 0x518 */ public List<TkNGuiGraphicStyle> GraphicStyles;
        /* 0x528 */ public List<TkNGuiTextStyle> TextStyles;
        /* 0x538 */ public List<float> SnapSettings;

        [NMS(Size = 8, Ignore = true)]
        /* 0x548 */ public byte[] EndPadding;
    }
}
