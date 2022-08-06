using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2D445ABC63C96EE5, NameHash = 0xD3ED2C768AB1847C)]
    public class GcPetTraitMoodModifierList : NMSTemplate
    {
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        public GcPetTraitMoodModifier[] Modifiers;
    }
}
