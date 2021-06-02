using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4C0, GUID = 0x8522736968AF8553, NameHash = 0x83E238320B2BEE42)]
    public class GcBaseBuildingMaterial : NMSTemplate
    {
        /* 0x00 */ public int MaterialIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        /* 0x08 */ public NMSString0x10 Name;
        /* 0x18 */ public TkTextureResource Icon;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x9C */ public byte[] Padding9C;
        /* 0xA0 */ public NMSString0x20 LocName;
        [NMS(Size = 0x10)]
        /* 0xC0 */ public GcBaseBuildingPalette[] Palettes;
    }
}
