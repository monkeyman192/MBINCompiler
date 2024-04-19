using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E74CFC329DC906E, NameHash = 0xF6B3A96F7D4F7967)]
    public class GcInventoryElement : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public GcInventoryIndex Index;
        /* 0x18 */ public int Amount;
        /* 0x1C */ public float DamageFactor;
        /* 0x20 */ public int MaxAmount;
        /* 0x24 */ public GcInventoryType Type;
        /* 0x28 */ public bool FullyInstalled;
    }
}
