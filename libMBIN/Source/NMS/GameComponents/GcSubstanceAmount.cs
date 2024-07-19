using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA6E10EE9956CD48E, NameHash = 0x8E7C8D0D)]
    public class GcSubstanceAmount : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 Specific;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSString0x10 SpecificSecondary;
        [NMS(Index = 1)]
        /* 0x20 */ public int AmountMax;
        [NMS(Index = 0)]
        /* 0x24 */ public int AmountMin;
        [NMS(Index = 4)]
        /* 0x28 */ public GcRealitySubstanceCategory Category;
        [NMS(Index = 5)]
        /* 0x2C */ public GcRarity Rarity;
    }
}
