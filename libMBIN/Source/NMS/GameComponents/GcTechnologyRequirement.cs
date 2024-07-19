using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x492364FBA29ACACC, NameHash = 0xC1DFA965)]
    public class GcTechnologyRequirement : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 2)]
        /* 0x10 */ public int Amount;
        [NMS(Index = 1)]
        /* 0x14 */ public GcInventoryType Type;
    }
}
