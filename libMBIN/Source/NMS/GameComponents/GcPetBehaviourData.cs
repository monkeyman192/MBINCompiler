using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97447D4CDBEF2B71, NameHash = 0x6EA8D576)]
    public class GcPetBehaviourData : NMSTemplate
    {
        [NMS(Index = 14)]
        /* 0x00 */ public NMSString0x20A LabelText;
        [NMS(Index = 10)]
        /* 0x20 */ public List<GcPetFollowUpBehaviour> FollowUpBehaviours;
        [NMS(Index = 12)]
        /* 0x30 */ public List<GcPetBehaviourMoodModifier> MoodBehaviourModifiers;
        [NMS(Index = 11)]
        /* 0x40 */ public List<GcPetBehaviourTraitModifier> TraitBehaviourModifiers;
        [NMS(Index = 13, Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x50 */ public float[] MoodModifyOnComplete;
        [NMS(Index = 7)]
        /* 0x58 */ public float ApproachPlayerDist;
        [NMS(Index = 6)]
        /* 0x5C */ public float ChatChance;
        [NMS(Index = 5)]
        /* 0x60 */ public float CooldownTime;
        [NMS(Index = 4)]
        /* 0x64 */ public float MaxPerformTime;
        [NMS(Index = 3)]
        /* 0x68 */ public float MinPerformTime;
        // size: 0x2
        public enum PetBehaviourValidityEnum : uint {
            Everywhere,
            OnPlanet,
        }
        [NMS(Index = 9)]
        /* 0x6C */ public PetBehaviourValidityEnum PetBehaviourValidity;
        [NMS(Index = 8)]
        /* 0x70 */ public float SearchDist;
        [NMS(Index = 2)]
        /* 0x74 */ public float Weight;
        [NMS(Index = 0)]
        /* 0x78 */ public bool ReactiveBehaviour;
        [NMS(Index = 1)]
        /* 0x79 */ public bool UsefulBehaviour;
    }
}
