using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1DA5865B8E6F16CB, NameHash = 0xE63B46A8CA0EF245)]
    public class GcPetMoodStaminaModifier : NMSTemplate
    {
        /* 0x00 */ public GcCreaturePetMood Mood;
        /* 0x04 */ public float MoodMax;
        /* 0x08 */ public float MoodMin;
        /* 0x0C */ public float StaminaDrainModifierMax;
        /* 0x10 */ public float StaminaDrainModifierMin;
        /* 0x14 */ public float StaminaRechargeModifierMax;
        /* 0x18 */ public float StaminaRechargeModifierMin;
    }
}
