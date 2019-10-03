using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD9414BBF03477303, Size = 0x130, NameHash = 0x9441C44CA7215426)]
    public class GcNPCPropInfo : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Model;
        /* 0x080 */ public bool Hologram;
        [NMS(Size = 0xF, Ignore = true)]
        /* 0x081 */ public byte[] Padding81;
        /* 0x090 */ public GcScanEffectData ScanEffect;
        [NMS(Size = 0x40)]
        /* 0x0E0 */ public string ScanEffectNodeName;
        /* 0x120 */ public float Weight;
        /* 0x124 */ public GcTechnologyCategory ShopType;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x128 */ public byte[] EndPadding;
    }
}
