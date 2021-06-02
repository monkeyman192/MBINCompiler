using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x13F68F082CC6D5AE, NameHash = 0xF6B3A96F7D4F7967)]
    public class GcInventoryElement : NMSTemplate
    {
        /* 0x00 */ public GcInventoryType Type;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        /* 0x08 */ public NMSString0x10 Id;
        /* 0x18 */ public int Amount;
        /* 0x1C */ public int MaxAmount;
        /* 0x20 */ public float DamageFactor;
        /* 0x24 */ public bool FullyInstalled;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x25 */ public byte[] Padding25;
        /* 0x28 */ public GcInventoryIndex Index;
    }
}
