using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA62C03A6C55D7A2F, NameHash = 0x264B878043DA20B3)]
    public class GcNGuiGraphicData : NMSTemplate
    {
        /* 0x000 */ public GcNGuiElementData ElementData;
        /* 0x080 */ public TkNGuiGraphicStyle Style;
        /* 0x2A0 */ public NMSString0x80 Image;
    }
}
