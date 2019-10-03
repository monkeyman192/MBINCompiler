using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x300, Alignment = 0x10, GUID = 0x5A9CCB25BAD0BBD8, NameHash = 0x264B878043DA20B3)]
    public class GcNGuiGraphicData : NMSTemplate
    {
        /* 0x000 */ public GcNGuiElementData ElementData;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x068 */ public byte[] Padding68;
        /* 0x070 */ public TkNGuiGraphicStyle Style;

        [NMS(Size = 0x80)]
        /* 0x280 */ public string Image;
    }
}
