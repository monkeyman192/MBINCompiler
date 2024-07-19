using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6F2DEB48FF1AA2AD, NameHash = 0xE9E49954)]
    public class TkNGuiEditorStyleData : NMSTemplate
    {
        [NMS(Index = 4, Size = 0x5D, EnumType = typeof(TkNGuiEditorGraphicType.NGuiEditorGraphicEnum))]
        /* 0x0000 */ public TkNGuiGraphicStyle[] GraphicStyles;
        [NMS(Index = 5, Size = 0xF, EnumType = typeof(TKNGuiEditorTextType.NGuiEditorTextEnum))]
        /* 0xBFD0 */ public TkNGuiTextStyle[] TextStyles;
        [NMS(Index = 1, Size = 0x8)]
        /* 0xD0B0 */ public TkNGuiEditorStyleColour[] SkinColours;
        [NMS(Index = 3)]
        /* 0xD530 */ public VariableSizeString Font;
        [NMS(Index = 7)]
        /* 0xD540 */ public List<TkNGuiLayoutShortcut> LayoutShortcuts;
        [NMS(Index = 6)]
        /* 0xD550 */ public List<float> SnapSettings;
        [NMS(Index = 0, Size = 0x3E, EnumType = typeof(TKNGuiEditorComponentSize.NGuiEditorComponentSizeEnum))]
        /* 0xD560 */ public float[] Sizes;
        [NMS(Index = 2)]
        /* 0xD658 */ public float SkinFontHeight;
        [NMS(Index = 8)]
        /* 0xD65C */ public bool Unfuck;
    }
}
