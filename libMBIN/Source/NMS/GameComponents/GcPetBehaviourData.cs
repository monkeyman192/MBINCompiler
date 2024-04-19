using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x285F130A426C7C92, NameHash = 0x309337FC0812738C)]
    public class GcPetBehaviourData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A LabelText;
        /* 0x20 */ public List<GcPetFollowUpBehaviour> FollowUpBehaviours;
        /* 0x30 */ public List<GcPetBehaviourMoodModifier> MoodBehaviourModifiers;
        /* 0x40 */ public List<GcPetBehaviourTraitModifier> TraitBehaviourModifiers;
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x50 */ public float[] MoodModifyOnComplete;
        /* 0x58 */ public float ApproachPlayerDist;
        /* 0x5C */ public float ChatChance;
        /* 0x60 */ public float CooldownTime;
        /* 0x64 */ public float MaxPerformTime;
        /* 0x68 */ public float MinPerformTime;
        // size: 0x2
        public enum PetBehaviourValidityEnum : uint {
            Everywhere,
            OnPlanet,
        }
        /* 0x6C */ public PetBehaviourValidityEnum PetBehaviourValidity;
        /* 0x70 */ public float SearchDist;
        /* 0x74 */ public float Weight;
        /* 0x78 */ public bool ReactiveBehaviour;
        /* 0x79 */ public bool UsefulBehaviour;
    }
}
