using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1F8, Alignment = 0x8, GUID = 0x9B51CEDAED51D099, NameHash = 0xE24B3D78ED0634BD)]
    public class GcDestructableComponentData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Explosion;
        /* 0x010 */ public float ExplosionScale;
        /* 0x014 */ public bool ExplosionScaleToBounds;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x015 */ public byte[] Padding15;
        /* 0x018 */ public NMSString0x10 VehicleDestroyEffect;
        /* 0x028 */ public NMSString0x10 TriggerAction;
        /* 0x038 */ public int IncreaseWanted;
        /* 0x03C */ public bool IncreaseFiendWanted;
        /* 0x040 */ public float IncreaseFiendWantedChance;
        /* 0x044 */ public bool NotifyEncounter;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x045 */ public byte[] Padding45;
        /* 0x048 */ public NMSString0x10 LootReward;
        /* 0x058 */ public int LootRewardAmountMin;
        /* 0x05C */ public int LootRewardAmountMax;
        /* 0x060 */ public bool CanDestroyFromStoredInteraction;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x061 */ public byte[] Padding61;
        /* 0x068 */ public List<GcSubstanceAmount> GivesSubstances;
        /* 0x078 */ public GcStatsEnum StatToTrack;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x07C */ public byte[] Padding7C;
        /* 0x080 */ public NMSString0x10 GivesReward;
        /* 0x090 */ public bool RewardIfDestroyedByOther;
        /* 0x091 */ public bool HideReward;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x092 */ public byte[] Padding92;
        /* 0x098 */ public NMSString0x20 OverrideRewardLoc;
        /* 0x0B8 */ public float HardModeSubstanceMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0BC */ public byte[] PaddingBC;
        /* 0x0C0 */ public List<GcRewardMissionOverride> RewardOverrideTable;
        /* 0x0D0 */ public bool ActivateLocatorsFromRarity;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x0D1 */ public byte[] PaddingD1;
        [NMS(Size = 0x3)]
        /* 0x0D8 */ public NMSString0x10[] RarityLocators;
        /* 0x108 */ public bool UseSystemColorsForTexture;
        /* 0x109 */ public bool RemoveModel;
        /* 0x10A */ public bool HideModel;
        /* 0x10C */ public TkTextureResource DestroyedModel;
        /* 0x190 */ public bool DestroyedModelUsesScale;
        /* 0x191 */ public bool DestroyedModelCollidesWithEverything;
        /* 0x194 */ public float DestroyForce;
        /* 0x198 */ public float DestroyForceRadius;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x19C */ public byte[] Padding19C;
        /* 0x1A0 */ public NMSString0x10 DestroyEffect;
        /* 0x1B0 */ public NMSString0x10 DestroyEffectPoint;
        /* 0x1C0 */ public float DestroyEffectTime;
        /* 0x1C4 */ public bool DestroyEffectMatrices;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x1C5 */ public byte[] Padding1C5;
        /* 0x1C8 */ public NMSString0x10 AreaDamage;
        /* 0x1D8 */ public bool ShowInteract;
        /* 0x1DC */ public float ShowInteractRange;
        /* 0x1E0 */ public bool GrenadeSingleHit;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x1E1 */ public byte[] Padding1E1;
        /* 0x1E8 */ public List<GcLootProbability> LootItems;
    }
}
