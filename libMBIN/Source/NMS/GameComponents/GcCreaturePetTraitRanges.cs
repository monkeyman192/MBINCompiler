using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEFDCACEE9B8C7255, NameHash = 0x55F9EF59F3B21D8)]
    public class GcCreaturePetTraitRanges : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitEnum))]
        /* 0x0 */ public GcCreaturePetTraitRange[] TraitRanges;
    }
}
