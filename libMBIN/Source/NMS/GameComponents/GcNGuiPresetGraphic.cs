using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED5F45E1F7793D51, NameHash = 0xA40EDAE)]
    public class GcNGuiPresetGraphic : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public TkNGuiGraphicStyle Style;
        [NMS(Index = 1)]
        /* 0x210 */ public GcNGuiLayoutData Layout;
        [NMS(Index = 3)]
        /* 0x258 */ public VariableSizeString Image;
        [NMS(Index = 0)]
        /* 0x268 */ public NMSString0x10 PresetID;
    }
}
