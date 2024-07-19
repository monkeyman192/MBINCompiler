using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x301D4A58138AA275, NameHash = 0xB180032)]
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
