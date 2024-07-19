using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB3D9800E36AFEE1E, NameHash = 0x52960A16)]
    public class GcCreaturePetTraitRanges : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitEnum))]
        /* 0x0 */ public GcCreaturePetTraitRange[] TraitRanges;
    }
}
