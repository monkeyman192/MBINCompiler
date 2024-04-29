using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x53CC919095828D9, NameHash = 0x7665E5534F420118)]
    public class GcPetBehaviourMoodModifier : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public float CooldownModifierMax;
        [NMS(Index = 5)]
        /* 0x04 */ public float CooldownModifierMin;
        [NMS(Index = 0)]
        /* 0x08 */ public GcCreaturePetMood Mood;
        [NMS(Index = 2)]
        /* 0x0C */ public float MoodMax;
        [NMS(Index = 1)]
        /* 0x10 */ public float MoodMin;
        [NMS(Index = 4)]
        /* 0x14 */ public float WeightModifierMax;
        [NMS(Index = 3)]
        /* 0x18 */ public float WeightModifierMin;
    }
}
