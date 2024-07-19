using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3EC10B7364826004, NameHash = 0x96E981DC)]
    public class GcPetTraitMoodModifierList : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x0 */ public GcPetTraitMoodModifier[] Modifiers;
    }
}
