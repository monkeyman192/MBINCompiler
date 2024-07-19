using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE6249CFD73DBDF10, NameHash = 0x1D0BA017)]
    public class GcNGuiPresetText : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public TkNGuiGraphicStyle GraphicStyle;
        [NMS(Index = 2)]
        /* 0x210 */ public TkNGuiTextStyle Style;
        [NMS(Index = 1)]
        /* 0x330 */ public GcNGuiLayoutData Layout;
        [NMS(Index = 4)]
        /* 0x378 */ public VariableSizeString Image;
        [NMS(Index = 0)]
        /* 0x388 */ public NMSString0x10 PresetID;
    }
}
