using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA28E0728D4AE9EBD, NameHash = 0xFC70ABE3)]
    public class GcDestructableComponentData : NMSTemplate
    {
        [NMS(Index = 29, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x000 */ public NMSString0x10[] RarityLocators;
        [NMS(Index = 26)]
        /* 0x030 */ public NMSString0x20A OverrideRewardLoc;
        [NMS(Index = 34)]
        /* 0x050 */ public TkModelResource DestroyedModel;
        [NMS(Index = 44)]
        /* 0x068 */ public NMSString0x10 AreaDamage;
        [NMS(Index = 39)]
        /* 0x078 */ public NMSString0x10 DestroyEffect;
        [NMS(Index = 41)]
        /* 0x088 */ public NMSString0x10 DestroyEffectPoint;
        [NMS(Index = 0)]
        /* 0x098 */ public NMSString0x10 Explosion;
        [NMS(Index = 19)]
        /* 0x0A8 */ public NMSString0x10 GivesReward;
        [NMS(Index = 17)]
        /* 0x0B8 */ public List<GcSubstanceAmount> GivesSubstances;
        [NMS(Index = 50)]
        /* 0x0C8 */ public List<GcLootProbability> LootItems;
        [NMS(Index = 13)]
        /* 0x0D8 */ public NMSString0x10 LootReward;
        [NMS(Index = 22)]
        /* 0x0E8 */ public NMSString0x10 PirateSystemAltReward;
        [NMS(Index = 27)]
        /* 0x0F8 */ public List<GcRewardMissionOverride> RewardOverrideTable;
        [NMS(Index = 5)]
        /* 0x108 */ public NMSString0x10 TriggerAction;
        [NMS(Index = 4)]
        /* 0x118 */ public NMSString0x10 VehicleDestroyEffect;
        [NMS(Index = 30, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x128 */ public int[] StandingChangeOnDeath;
        [NMS(Index = 42)]
        /* 0x150 */ public float DestroyEffectTime;
        [NMS(Index = 37)]
        /* 0x154 */ public float DestroyForce;
        [NMS(Index = 38)]
        /* 0x158 */ public float DestroyForceRadius;
        [NMS(Index = 1)]
        /* 0x15C */ public float ExplosionScale;
        [NMS(Index = 7)]
        /* 0x160 */ public int IncreaseCorruptSentinelWanted;
        [NMS(Index = 10)]
        /* 0x164 */ public GcFiendCrime IncreaseFiendCrime;
        [NMS(Index = 9)]
        /* 0x168 */ public float IncreaseFiendWantedChance;
        [NMS(Index = 6)]
        /* 0x16C */ public int IncreaseWanted;
        [NMS(Index = 15)]
        /* 0x170 */ public int LootRewardAmountMax;
        [NMS(Index = 14)]
        /* 0x174 */ public int LootRewardAmountMin;
        [NMS(Index = 21)]
        /* 0x178 */ public int OverrideChipAmount;
        [NMS(Index = 47)]
        /* 0x17C */ public float ShowInteractRange;
        [NMS(Index = 18)]
        /* 0x180 */ public GcStatsEnum StatToTrack;
        [NMS(Index = 28)]
        /* 0x184 */ public bool ActivateLocatorsFromRarity;
        [NMS(Index = 20)]
        /* 0x185 */ public bool BlockDestructionIfRewardFails;
        [NMS(Index = 16)]
        /* 0x186 */ public bool CanDestroyFromStoredInteraction;
        [NMS(Index = 12)]
        /* 0x187 */ public bool DamagesParentWhenDestroyed;
        [NMS(Index = 36)]
        /* 0x188 */ public bool DestroyedModelCollidesWithEverything;
        [NMS(Index = 35)]
        /* 0x189 */ public bool DestroyedModelUsesScale;
        [NMS(Index = 43)]
        /* 0x18A */ public bool DestroyEffectMatrices;
        [NMS(Index = 40)]
        /* 0x18B */ public bool DestroyEffectOnSurface;
        [NMS(Index = 2)]
        /* 0x18C */ public bool ExplosionScaleToBounds;
        [NMS(Index = 49)]
        /* 0x18D */ public bool GrenadeSingleHit;
        [NMS(Index = 46)]
        /* 0x18E */ public bool HideInteractWhenAllArmourDestroyed;
        [NMS(Index = 48)]
        /* 0x18F */ public bool HideInteractWhenShielded;
        [NMS(Index = 33)]
        /* 0x190 */ public bool HideModel;
        [NMS(Index = 25)]
        /* 0x191 */ public bool HideReward;
        [NMS(Index = 8)]
        /* 0x192 */ public bool IncreaseFiendWanted;
        [NMS(Index = 24)]
        /* 0x193 */ public bool NoConsequencesDuringPirateBattle;
        [NMS(Index = 11)]
        /* 0x194 */ public bool NotifyEncounter;
        [NMS(Index = 3)]
        /* 0x195 */ public bool OnlyExplodeSelf;
        [NMS(Index = 32)]
        /* 0x196 */ public bool RemoveModel;
        [NMS(Index = 23)]
        /* 0x197 */ public bool RewardIfDestroyedByOther;
        [NMS(Index = 45)]
        /* 0x198 */ public bool ShowInteract;
        [NMS(Index = 31)]
        /* 0x199 */ public bool UseSystemColorsForTexture;
    }
}
