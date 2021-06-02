using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x80, GUID = 0x634CD9FEA02E73F9, NameHash = 0x309337FC0812738C)]
    public class GcPetBehaviourData : NMSTemplate
    {
        /* 0x00 */ public bool ReactiveBehaviour;
        /* 0x01 */ public bool UsefulBehaviour;
        /* 0x04 */ public float Weight;
        /* 0x08 */ public float MinPerformTime;
        /* 0x0C */ public float MaxPerformTime;
        /* 0x10 */ public float CooldownTime;
        /* 0x14 */ public float ChatChance;
        /* 0x18 */ public float ApproachPlayerDist;
        /* 0x1C */ public float SearchDist;
        public enum PetBehaviourValidityEnum { Everywhere, OnPlanet }
        /* 0x20 */ public PetBehaviourValidityEnum PetBehaviourValidity;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x24 */ public byte[] Padding24;
        /* 0x28 */ public List<GcPetFollowUpBehaviour> FollowUpBehaviours;
        /* 0x38 */ public List<GcPetBehaviourTraitModifier> TraitBehaviourModifiers;
        /* 0x48 */ public List<GcPetBehaviourMoodModifier> MoodBehaviourModifiers;
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x58 */ public float[] MoodModifyOnComplete;
        /* 0x60 */ public NMSString0x20 LabelText;
    }
}
