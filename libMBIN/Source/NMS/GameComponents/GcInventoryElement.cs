using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA6916AF214CA9CC9, NameHash = 0xF6B3A96F7D4F7967)]
    public class GcInventoryElement : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 6)]
        /* 0x10 */ public GcInventoryIndex Index;
        [NMS(Index = 2)]
        /* 0x18 */ public int Amount;
        [NMS(Index = 4)]
        /* 0x1C */ public float DamageFactor;
        [NMS(Index = 3)]
        /* 0x20 */ public int MaxAmount;
        [NMS(Index = 0)]
        /* 0x24 */ public GcInventoryType Type;
        [NMS(Index = 5)]
        /* 0x28 */ public bool FullyInstalled;
    }
}
