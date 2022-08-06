using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E3642E410CB8983, NameHash = 0xEB530C995C41BAF0)]
    public class GcPetActionMoodModifier : NMSTemplate
    {
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        public float[] MoodModifiers;
    }
}
