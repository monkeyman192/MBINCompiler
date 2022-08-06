using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF089BEE581695079, NameHash = 0x39BD1ED2FC8D7524)]
    public class GcPetBehaviourTable : NMSTemplate
    {
        [NMS(Size = 0x1C, EnumType = typeof(GcPetBehaviours.PetBehaviourEnum))]
        /* 0x0000 */ public GcPetBehaviourData[] Behaviours;
        /* 0x0E00 */ public float GlobalCooldownModifier;
        /* 0x0E04 */ public float UsefulBehaviourLinkedCooldownAmount;
        /* 0x0E08 */ public float PlayerActivityIncreaseTime;
        /* 0x0E0C */ public float PlayerActivityDecreaseTime;
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x0E10 */ public float[] MoodIncreaseTime;
        [NMS(Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitsEnum))]
        /* 0x0E18 */ public GcPetTraitMoodModifierList[] TraitMoodModifiers;
        [NMS(Size = 0x9, EnumType = typeof(GcCreaturePetRewardActions.PetActionEnum))]
        /* 0x0E78 */ public GcPetActionMoodModifier[] RewardMoodModifier;
        [NMS(Size = 0xB, EnumType = typeof(GcCreatureRoles.CreatureRoleEnum))]
        /* 0x0EC0 */ public GcCreaturePetTraitRanges[] TraitRanges;
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x0FC8 */ public float[] MoodValuesOnAdopt;
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x0FD0 */ public float[] MoodValuesOnHatch;
        /* 0x0FD8 */ public List<GcPetTraitStaminaModifier> TraitStaminaModifiers;
        /* 0x0FE8 */ public List<GcPetMoodStaminaModifier> MoodStaminaModifiers;
        /* 0x0FF8 */ public float AccessoryGyroFollowMotionStrength;
        /* 0x0FFC */ public float AccessoryGyroToNeutralStrength;
        /* 0x1000 */ public float AccessoryGyroDamping;
        /* 0x1004 */ public float AccessoryGyroStrength;
        /* 0x1008 */ public bool AccessoryGyroActive;
    }
}
