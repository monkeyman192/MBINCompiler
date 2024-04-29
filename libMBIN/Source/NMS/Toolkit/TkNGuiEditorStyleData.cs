using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF0C2A60450C73435, NameHash = 0x6F26BF19981BB60C)]
    public class TkNGuiEditorStyleData : NMSTemplate
    {
        [NMS(Index = 4, Size = 0x4D, EnumType = typeof(TkNGuiEditorGraphicType.NGuiEditorGraphicEnum))]
        /* 0x0000 */ public TkNGuiGraphicStyle[] GraphicStyles;
        [NMS(Index = 5, Size = 0xE, EnumType = typeof(TKNGuiEditorTextType.NGuiEditorTextEnum))]
        /* 0x9060 */ public TkNGuiTextStyle[] TextStyles;
        [NMS(Index = 1, Size = 0x8)]
        /* 0xA020 */ public TkNGuiEditorStyleColour[] SkinColours;
        [NMS(Index = 6)]
        /* 0xA4A0 */ public List<float> SnapSettings;
        [NMS(Index = 0, Size = 0x30, EnumType = typeof(TKNGuiEditorComponentSize.NGuiEditorComponentSizeEnum))]
        /* 0xA4B0 */ public float[] Sizes;
        [NMS(Index = 2)]
        /* 0xA570 */ public float SkinFontHeight;
        [NMS(Index = 3)]
        /* 0xA574 */ public NMSString0x80 Font;
    }
}
