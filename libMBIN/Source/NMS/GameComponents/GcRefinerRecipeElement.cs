using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF2F40D6592F2F33A, NameHash = 0x5BA3C705)]
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
