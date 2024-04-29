using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE4F2B41162B42036, NameHash = 0xD3ED2C768AB1847C)]
    public class GcPetTraitMoodModifierList : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x0 */ public GcPetTraitMoodModifier[] Modifiers;
    }
}
