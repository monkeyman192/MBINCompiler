using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x78F621A5B62DEA07, NameHash = 0x39BD1ED2FC8D7524)]
    public class GcPetBehaviourTable : NMSTemplate
    {
        [NMS(Size = 0x1C, EnumType = typeof(GcPetBehaviours.PetBehaviourEnum))]
        /* 0x0000 */ public GcPetBehaviourData[] Behaviours;
        /* 0x0E00 */ public List<GcPetMoodStaminaModifier> MoodStaminaModifiers;
        /* 0x0E10 */ public List<GcPetTraitStaminaModifier> TraitStaminaModifiers;
        [NMS(Size = 0xB, EnumType = typeof(GcCreatureRoles.CreatureRoleEnum))]
        /* 0x0E20 */ public GcCreaturePetTraitRanges[] TraitRanges;
        [NMS(Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitEnum))]
        /* 0x0F28 */ public GcPetTraitMoodModifierList[] TraitMoodModifiers;
        [NMS(Size = 0x9, EnumType = typeof(GcCreaturePetRewardActions.PetActionEnum))]
        /* 0x0F88 */ public GcPetActionMoodModifier[] RewardMoodModifier;
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x0FD0 */ public float[] MoodIncreaseTime;
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x0FD8 */ public float[] MoodValuesOnAdopt;
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x0FE0 */ public float[] MoodValuesOnHatch;
        /* 0x0FE8 */ public float AccessoryGyroDamping;
        /* 0x0FEC */ public float AccessoryGyroFollowMotionStrength;
        /* 0x0FF0 */ public float AccessoryGyroStrength;
        /* 0x0FF4 */ public float AccessoryGyroToNeutralStrength;
        /* 0x0FF8 */ public float GlobalCooldownModifier;
        /* 0x0FFC */ public float PlayerActivityDecreaseTime;
        /* 0x1000 */ public float PlayerActivityIncreaseTime;
        /* 0x1004 */ public float UsefulBehaviourLinkedCooldownAmount;
        /* 0x1008 */ public bool AccessoryGyroActive;
    }
}
