using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x13F68F082CC6D5AE, NameHash = 0xF6B3A96F7D4F7967)]
    public class GcInventoryElement : NMSTemplate
    {
        /* 0x00 */ public GcInventoryType Type;
        /* 0x08 */ public NMSString0x10 Id;
        /* 0x18 */ public int Amount;
        /* 0x1C */ public int MaxAmount;
        /* 0x20 */ public float DamageFactor;
        /* 0x24 */ public bool FullyInstalled;
        /* 0x28 */ public GcInventoryIndex Index;
    }
}
