using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7795CBB86D613DF2, NameHash = 0xE9E49954)]
    public class TkNGuiEditorStyleData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x8, MxmlName = "Skin Colours")]
        /* 0x0000 */ public TkNGuiEditorStyleColour[] SkinColours;
        [NMS(Index = 3)]
        /* 0x0480 */ public GcFilename Font;
        [NMS(Index = 5)]
        /* 0x0490 */ public GcFilename FontDebug;
        [NMS(Index = 4)]
        /* 0x04A0 */ public GcFilename FontMono;
        [NMS(Index = 9)]
        /* 0x04B0 */ public List<TkNGuiLayoutShortcut> LayoutShortcuts;
        [NMS(Index = 8)]
        /* 0x04C0 */ public List<float> SnapSettings;
        [NMS(Index = 6, Size = 0x60, EnumType = typeof(TkNGuiEditorGraphicType.NGuiEditorGraphicEnum))]
        /* 0x04D0 */ public TkNGuiGraphicStyle[] GraphicStyles;
        [NMS(Index = 7, Size = 0xF, EnumType = typeof(TKNGuiEditorTextType.NGuiEditorTextEnum))]
        /* 0x94D0 */ public TkNGuiTextStyle[] TextStyles;
        [NMS(Index = 0, Size = 0x42, EnumType = typeof(TKNGuiEditorComponentSize.NGuiEditorComponentSizeEnum))]
        /* 0x9F5C */ public float[] Sizes;
        [NMS(Index = 2, MxmlName = "Skin Font Height")]
        /* 0xA064 */ public float SkinFontHeight;
    }
}
