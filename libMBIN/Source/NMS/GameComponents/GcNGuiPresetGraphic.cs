using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA595C87BF0ED48AC, NameHash = 0x247C56DDB7B4E25A)]
    public class GcNGuiPresetGraphic : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public TkNGuiGraphicStyle Style;
        [NMS(Index = 1)]
        /* 0x1E0 */ public GcNGuiLayoutData Layout;
        [NMS(Index = 0)]
        /* 0x228 */ public NMSString0x10 PresetID;
        [NMS(Index = 3)]
        /* 0x238 */ public NMSString0x80 Image;
    }
}
