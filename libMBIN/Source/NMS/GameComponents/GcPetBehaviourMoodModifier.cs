using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8D3E77D7F2B1C8B2, NameHash = 0x7665E5534F420118)]
    public class GcPetBehaviourMoodModifier : NMSTemplate
    {
        /* 0x00 */ public float CooldownModifierMax;
        /* 0x04 */ public float CooldownModifierMin;
        /* 0x08 */ public GcCreaturePetMood Mood;
        /* 0x0C */ public float MoodMax;
        /* 0x10 */ public float MoodMin;
        /* 0x14 */ public float WeightModifierMax;
        /* 0x18 */ public float WeightModifierMin;
    }
}
