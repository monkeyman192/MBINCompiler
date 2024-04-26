using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x78F621A5B62DEA07, NameHash = 0x39BD1ED2FC8D7524)]
    public class GcPetBehaviourTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x1C, EnumType = typeof(GcPetBehaviours.PetBehaviourEnum))]
        /* 0x0000 */ public GcPetBehaviourData[] Behaviours;
        [NMS(Index = 12)]
        /* 0x0E00 */ public List<GcPetMoodStaminaModifier> MoodStaminaModifiers;
        [NMS(Index = 11)]
        /* 0x0E10 */ public List<GcPetTraitStaminaModifier> TraitStaminaModifiers;
        [NMS(Index = 8, Size = 0xB, EnumType = typeof(GcCreatureRoles.CreatureRoleEnum))]
        /* 0x0E20 */ public GcCreaturePetTraitRanges[] TraitRanges;
        [NMS(Index = 6, Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitEnum))]
        /* 0x0F28 */ public GcPetTraitMoodModifierList[] TraitMoodModifiers;
        [NMS(Index = 7, Size = 0x9, EnumType = typeof(GcCreaturePetRewardActions.PetActionEnum))]
        /* 0x0F88 */ public GcPetActionMoodModifier[] RewardMoodModifier;
        [NMS(Index = 5, Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x0FD0 */ public float[] MoodIncreaseTime;
        [NMS(Index = 9, Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x0FD8 */ public float[] MoodValuesOnAdopt;
        [NMS(Index = 10, Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x0FE0 */ public float[] MoodValuesOnHatch;
        [NMS(Index = 15)]
        /* 0x0FE8 */ public float AccessoryGyroDamping;
        [NMS(Index = 13)]
        /* 0x0FEC */ public float AccessoryGyroFollowMotionStrength;
        [NMS(Index = 16)]
        /* 0x0FF0 */ public float AccessoryGyroStrength;
        [NMS(Index = 14)]
        /* 0x0FF4 */ public float AccessoryGyroToNeutralStrength;
        [NMS(Index = 1)]
        /* 0x0FF8 */ public float GlobalCooldownModifier;
        [NMS(Index = 4)]
        /* 0x0FFC */ public float PlayerActivityDecreaseTime;
        [NMS(Index = 3)]
        /* 0x1000 */ public float PlayerActivityIncreaseTime;
        [NMS(Index = 2)]
        /* 0x1004 */ public float UsefulBehaviourLinkedCooldownAmount;
        [NMS(Index = 17)]
        /* 0x1008 */ public bool AccessoryGyroActive;
    }
}
