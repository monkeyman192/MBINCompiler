using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDC18A7976A6499F6, NameHash = 0x8685F03E)]
    public class GcCostInteractionIndex : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x20A CantAffordLocID;
        [NMS(Index = 2)]
        /* 0x20 */ public int Index;
        [NMS(Index = 0)]
        /* 0x24 */ public GcInteractionType InteractionType;
        [NMS(Index = 1)]
        /* 0x28 */ public GcAlienRace Race;
        [NMS(Index = 3)]
        /* 0x2C */ public bool AffordIfGreaterThanIndex;
    }
}
