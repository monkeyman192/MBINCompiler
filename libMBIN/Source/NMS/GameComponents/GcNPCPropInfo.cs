using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x130, GUID = 0x2B5E9678F25FC6E8, NameHash = 0x9441C44CA7215426)]
    public class GcNPCPropInfo : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Model;
        /* 0x080 */ public bool Hologram;
        [NMS(Size = 0xF, Ignore = true)]
        /* 0x081 */ public byte[] Padding81;
        /* 0x090 */ public GcScanEffectData ScanEffect;
        /* 0x0E0 */ public NMSString0x40 ScanEffectNodeName;
        /* 0x120 */ public float Weight;
        /* 0x124 */ public GcTechnologyCategory ShopType;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x128 */ public byte[] EndPadding;
    }
}
