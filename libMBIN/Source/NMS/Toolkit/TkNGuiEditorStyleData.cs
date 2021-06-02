using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xAEA0, GUID = 0x97BBEC400DB04410, NameHash = 0x6F26BF19981BB60C)]
    public class TkNGuiEditorStyleData : NMSTemplate
    {
        [NMS(Size = 0x30, EnumType = typeof(TKNGuiEditorComponentSize.NGuiEditorComponentSizeEnum))]
        /* 0x0000 */ public float[] Sizes;
        [NMS(Size = 0x8)]
        /* 0x00C0 */ public TkNGuiEditorStyleColour[] SkinColours;
        /* 0x0540 */ public float SkinFontHeight;
        /* 0x0544 */ public NMSString0x80 Font;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x05C4 */ public byte[] Padding5C4;
        [NMS(Size = 0x48, EnumType = typeof(TkNGuiEditorGraphicType.NGuiEditorGraphicEnum))]
        /* 0x05D0 */ public TkNGuiGraphicStyle[] GraphicStyles;
        [NMS(Size = 0xE, EnumType = typeof(TKNGuiEditorTextType.NGuiEditorTextEnum))]
        /* 0x9ED0 */ public TkNGuiTextStyle[] TextStyles;
        /* 0xAE90 */ public List<float> SnapSettings;
    }
}
