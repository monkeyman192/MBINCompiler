using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6E9E0406C0AD2E94, NameHash = 0x247C56DDB7B4E25A)]
    public class GcNGuiPresetGraphic : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 PresetID;
        /* 0x010 */ public GcNGuiLayoutData Layout;
        /* 0x060 */ public TkNGuiGraphicStyle Style;
        /* 0x280 */ public NMSString0x80 Image;
    }
}
