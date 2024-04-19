using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x71A916A9EEA62B74, NameHash = 0xED358CC87699CBEA)]
    public class GcFrigateTraitStrengthValues : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A StatLocID;
        [NMS(Size = 0xA, EnumType = typeof(GcFrigateTraitStrength.FrigateTraitStrengthEnum))]
        /* 0x20 */ public int[] StatAlteration;
        /* 0x48 */ public bool StatDisplaysPositive;
    }
}
