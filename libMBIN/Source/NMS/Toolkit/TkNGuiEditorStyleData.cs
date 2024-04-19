using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC6666317D0907616, NameHash = 0x6F26BF19981BB60C)]
    public class TkNGuiEditorStyleData : NMSTemplate
    {
        [NMS(Size = 0x4D, EnumType = typeof(TkNGuiEditorGraphicType.NGuiEditorGraphicEnum))]
        /* 0x0000 */ public TkNGuiGraphicStyle[] GraphicStyles;
        [NMS(Size = 0xE, EnumType = typeof(TKNGuiEditorTextType.NGuiEditorTextEnum))]
        /* 0x9060 */ public TkNGuiTextStyle[] TextStyles;
        [NMS(Size = 0x8)]
        /* 0xA020 */ public TkNGuiEditorStyleColour[] SkinColours;
        /* 0xA4A0 */ public List<float> SnapSettings;
        [NMS(Size = 0x30, EnumType = typeof(TKNGuiEditorComponentSize.NGuiEditorComponentSizeEnum))]
        /* 0xA4B0 */ public float[] Sizes;
        /* 0xA570 */ public float SkinFontHeight;
        /* 0xA574 */ public NMSString0x80 Font;
    }
}
