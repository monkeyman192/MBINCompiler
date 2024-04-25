using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x71A916A9EEA62B74, NameHash = 0xED358CC87699CBEA)]
    public class GcFrigateTraitStrengthValues : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A StatLocID;
        [NMS(Index = 0, Size = 0xA, EnumType = typeof(GcFrigateTraitStrength.FrigateTraitStrengthEnum))]
        /* 0x20 */ public int[] StatAlteration;
        [NMS(Index = 2)]
        /* 0x48 */ public bool StatDisplaysPositive;
    }
}
