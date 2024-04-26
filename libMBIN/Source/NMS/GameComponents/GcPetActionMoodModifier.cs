using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3695ECADA7CB07DC, NameHash = 0xEB530C995C41BAF0)]
    public class GcPetActionMoodModifier : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x0 */ public float[] MoodModifiers;
    }
}
