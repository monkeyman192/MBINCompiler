using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA6532DABE5A58927, NameHash = 0xE63B46A8CA0EF245)]
    public class GcPetMoodStaminaModifier : NMSTemplate
    {
        /* 0x00 */ public GcCreaturePetMood Mood;
        /* 0x04 */ public float MoodMin;
        /* 0x04 */ public float MoodMax;
        /* 0x04 */ public float StaminaDrainModifierMin;
        /* 0x04 */ public float StaminaDrainModifierMax;
        /* 0x04 */ public float StaminaRechargeModifierMin;
        /* 0x04 */ public float StaminaRechargeModifierMax;
    }
}
