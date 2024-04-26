using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFA260C4B6F9A60E0, NameHash = 0x264B878043DA20B3)]
    public class GcNGuiGraphicData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public TkNGuiGraphicStyle Style;
        [NMS(Index = 0)]
        /* 0x1E0 */ public GcNGuiElementData ElementData;
        [NMS(Index = 2)]
        /* 0x250 */ public NMSString0x80 Image;
    }
}
