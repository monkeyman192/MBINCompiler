using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC63CBB76AABD52D4, NameHash = 0x247C56DDB7B4E25A)]
    public class GcNGuiPresetGraphic : NMSTemplate
    {
        /* 0x000 */ public TkNGuiGraphicStyle Style;
        /* 0x1E0 */ public GcNGuiLayoutData Layout;
        /* 0x228 */ public NMSString0x10 PresetID;
        /* 0x238 */ public NMSString0x80 Image;
    }
}
