using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x19662D2A94700606, NameHash = 0xE24B3D78ED0634BD)]
    public class GcDestructableComponentData : NMSTemplate
    {
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x000 */ public NMSString0x10[] RarityLocators;
        /* 0x030 */ public NMSString0x20A OverrideRewardLoc;
        /* 0x050 */ public NMSString0x10 AreaDamage;
        /* 0x060 */ public NMSString0x10 DestroyEffect;
        /* 0x070 */ public NMSString0x10 DestroyEffectPoint;
        /* 0x080 */ public NMSString0x10 Explosion;
        /* 0x090 */ public NMSString0x10 GivesReward;
        /* 0x0A0 */ public List<GcSubstanceAmount> GivesSubstances;
        /* 0x0B0 */ public List<GcLootProbability> LootItems;
        /* 0x0C0 */ public NMSString0x10 LootReward;
        /* 0x0D0 */ public NMSString0x10 PirateSystemAltReward;
        /* 0x0E0 */ public List<GcRewardMissionOverride> RewardOverrideTable;
        /* 0x0F0 */ public NMSString0x10 TriggerAction;
        /* 0x100 */ public NMSString0x10 VehicleDestroyEffect;
        /* 0x110 */ public TkModelResource DestroyedModel;
        [NMS(Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x194 */ public int[] StandingChangeOnDeath;
        /* 0x1BC */ public float DestroyEffectTime;
        /* 0x1C0 */ public float DestroyForce;
        /* 0x1C4 */ public float DestroyForceRadius;
        /* 0x1C8 */ public float ExplosionScale;
        /* 0x1CC */ public int IncreaseCorruptSentinelWanted;
        /* 0x1D0 */ public float IncreaseFiendWantedChance;
        /* 0x1D4 */ public int IncreaseWanted;
        /* 0x1D8 */ public int LootRewardAmountMax;
        /* 0x1DC */ public int LootRewardAmountMin;
        /* 0x1E0 */ public int OverrideChipAmount;
        /* 0x1E4 */ public float ShowInteractRange;
        /* 0x1E8 */ public GcStatsEnum StatToTrack;
        /* 0x1EC */ public bool ActivateLocatorsFromRarity;
        /* 0x1ED */ public bool BlockDestructionIfRewardFails;
        /* 0x1EE */ public bool CanDestroyFromStoredInteraction;
        /* 0x1EF */ public bool DamagesParentWhenDestroyed;
        /* 0x1F0 */ public bool DestroyedModelCollidesWithEverything;
        /* 0x1F1 */ public bool DestroyedModelUsesScale;
        /* 0x1F2 */ public bool DestroyEffectMatrices;
        /* 0x1F3 */ public bool DestroyEffectOnSurface;
        /* 0x1F4 */ public bool ExplosionScaleToBounds;
        /* 0x1F5 */ public bool GrenadeSingleHit;
        /* 0x1F6 */ public bool HideInteractWhenAllArmourDestroyed;
        /* 0x1F7 */ public bool HideInteractWhenShielded;
        /* 0x1F8 */ public bool HideModel;
        /* 0x1F9 */ public bool HideReward;
        /* 0x1FA */ public bool IncreaseFiendWanted;
        /* 0x1FB */ public bool NoConsequencesDuringPirateBattle;
        /* 0x1FC */ public bool NotifyEncounter;
        /* 0x1FD */ public bool OnlyExplodeSelf;
        /* 0x1FE */ public bool RemoveModel;
        /* 0x1FF */ public bool RewardIfDestroyedByOther;
        /* 0x200 */ public bool ShowInteract;
        /* 0x201 */ public bool UseSystemColorsForTexture;
    }
}
