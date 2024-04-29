using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBAA4F5B6412A4149, NameHash = 0xE6D47DFF06BD69E5)]
    public class GcRefinerRecipeElement : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 2)]
        /* 0x10 */ public int Amount;
        [NMS(Index = 1)]
        /* 0x14 */ public GcInventoryType Type;
    }
}
