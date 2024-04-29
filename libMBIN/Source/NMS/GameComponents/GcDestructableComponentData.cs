using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6AABE0E4D099CCBF, NameHash = 0xE24B3D78ED0634BD)]
    public class GcDestructableComponentData : NMSTemplate
    {
        [NMS(Index = 28, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x000 */ public NMSString0x10[] RarityLocators;
        [NMS(Index = 25)]
        /* 0x030 */ public NMSString0x20A OverrideRewardLoc;
        [NMS(Index = 43)]
        /* 0x050 */ public NMSString0x10 AreaDamage;
        [NMS(Index = 38)]
        /* 0x060 */ public NMSString0x10 DestroyEffect;
        [NMS(Index = 40)]
        /* 0x070 */ public NMSString0x10 DestroyEffectPoint;
        [NMS(Index = 0)]
        /* 0x080 */ public NMSString0x10 Explosion;
        [NMS(Index = 18)]
        /* 0x090 */ public NMSString0x10 GivesReward;
        [NMS(Index = 16)]
        /* 0x0A0 */ public List<GcSubstanceAmount> GivesSubstances;
        [NMS(Index = 49)]
        /* 0x0B0 */ public List<GcLootProbability> LootItems;
        [NMS(Index = 12)]
        /* 0x0C0 */ public NMSString0x10 LootReward;
        [NMS(Index = 21)]
        /* 0x0D0 */ public NMSString0x10 PirateSystemAltReward;
        [NMS(Index = 26)]
        /* 0x0E0 */ public List<GcRewardMissionOverride> RewardOverrideTable;
        [NMS(Index = 5)]
        /* 0x0F0 */ public NMSString0x10 TriggerAction;
        [NMS(Index = 4)]
        /* 0x100 */ public NMSString0x10 VehicleDestroyEffect;
        [NMS(Index = 33)]
        /* 0x110 */ public TkModelResource DestroyedModel;
        [NMS(Index = 29, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x194 */ public int[] StandingChangeOnDeath;
        [NMS(Index = 41)]
        /* 0x1BC */ public float DestroyEffectTime;
        [NMS(Index = 36)]
        /* 0x1C0 */ public float DestroyForce;
        [NMS(Index = 37)]
        /* 0x1C4 */ public float DestroyForceRadius;
        [NMS(Index = 1)]
        /* 0x1C8 */ public float ExplosionScale;
        [NMS(Index = 7)]
        /* 0x1CC */ public int IncreaseCorruptSentinelWanted;
        [NMS(Index = 9)]
        /* 0x1D0 */ public float IncreaseFiendWantedChance;
        [NMS(Index = 6)]
        /* 0x1D4 */ public int IncreaseWanted;
        [NMS(Index = 14)]
        /* 0x1D8 */ public int LootRewardAmountMax;
        [NMS(Index = 13)]
        /* 0x1DC */ public int LootRewardAmountMin;
        [NMS(Index = 20)]
        /* 0x1E0 */ public int OverrideChipAmount;
        [NMS(Index = 46)]
        /* 0x1E4 */ public float ShowInteractRange;
        [NMS(Index = 17)]
        /* 0x1E8 */ public GcStatsEnum StatToTrack;
        [NMS(Index = 27)]
        /* 0x1EC */ public bool ActivateLocatorsFromRarity;
        [NMS(Index = 19)]
        /* 0x1ED */ public bool BlockDestructionIfRewardFails;
        [NMS(Index = 15)]
        /* 0x1EE */ public bool CanDestroyFromStoredInteraction;
        [NMS(Index = 11)]
        /* 0x1EF */ public bool DamagesParentWhenDestroyed;
        [NMS(Index = 35)]
        /* 0x1F0 */ public bool DestroyedModelCollidesWithEverything;
        [NMS(Index = 34)]
        /* 0x1F1 */ public bool DestroyedModelUsesScale;
        [NMS(Index = 42)]
        /* 0x1F2 */ public bool DestroyEffectMatrices;
        [NMS(Index = 39)]
        /* 0x1F3 */ public bool DestroyEffectOnSurface;
        [NMS(Index = 2)]
        /* 0x1F4 */ public bool ExplosionScaleToBounds;
        [NMS(Index = 48)]
        /* 0x1F5 */ public bool GrenadeSingleHit;
        [NMS(Index = 45)]
        /* 0x1F6 */ public bool HideInteractWhenAllArmourDestroyed;
        [NMS(Index = 47)]
        /* 0x1F7 */ public bool HideInteractWhenShielded;
        [NMS(Index = 32)]
        /* 0x1F8 */ public bool HideModel;
        [NMS(Index = 24)]
        /* 0x1F9 */ public bool HideReward;
        [NMS(Index = 8)]
        /* 0x1FA */ public bool IncreaseFiendWanted;
        [NMS(Index = 23)]
        /* 0x1FB */ public bool NoConsequencesDuringPirateBattle;
        [NMS(Index = 10)]
        /* 0x1FC */ public bool NotifyEncounter;
        [NMS(Index = 3)]
        /* 0x1FD */ public bool OnlyExplodeSelf;
        [NMS(Index = 31)]
        /* 0x1FE */ public bool RemoveModel;
        [NMS(Index = 22)]
        /* 0x1FF */ public bool RewardIfDestroyedByOther;
        [NMS(Index = 44)]
        /* 0x200 */ public bool ShowInteract;
        [NMS(Index = 30)]
        /* 0x201 */ public bool UseSystemColorsForTexture;
    }
}
