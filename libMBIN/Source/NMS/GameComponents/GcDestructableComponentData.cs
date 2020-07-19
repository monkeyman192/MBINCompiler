using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1D8, Alignment = 0x8, GUID = 0x1EE6DB1CF9B7C51B, NameHash = 0xE24B3D78ED0634BD)]
    public class GcDestructableComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Explosion;
        /* 0x010 */ public float ExplosionScale;
        /* 0x014 */ public bool ExplosionScaleToBounds;
        [NMS(Size = 3, Ignore = true)]
        /* 0x015 */ public byte[] Padding15;

        [NMS(Size = 0x10)]
        /* 0x018 */ public string VehicleDestroyEffect;

        [NMS(Size = 0x10)]
        /* 0x028 */ public string TriggerAction;
        /* 0x038 */ public int IncreaseWanted;
        /* 0x03C */ public bool IncreaseFiendWanted;
        /* 0x03D */ public bool NotifyEncounter;
        [NMS(Size = 2, Ignore = true)]
        /* 0x03E */ public byte[] Padding3E;

        [NMS(Size = 0x10)]
        /* 0x040 */ public string LootReward;

        /* 0x050 */ public int LootRewardAmountMin;
        /* 0x054 */ public int LootRewardAmountMax;

        /* 0x058 */ public List<GcSubstanceAmount> GivesSubstances;

        /* 0x068 */ public GcStatsEnum StatsToTrack;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x06C */ public byte[] Padding6C;

        [NMS(Size = 0x10)]
        /* 0x070 */ public string GivesReward;
        /* 0x080 */ public bool HideReward;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x081 */ public byte[] Padding81;
        [NMS(Size = 0x20)]
        /* 0x088 */ public string OverrideRewardLoc;
		/* 0x0A8 */ public float HardModeSubstanceMultiplier;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0AC */ public byte[] PaddingAC;

        /* 0x0B0 */ public List<GcRewardMissionOverride> RewardOverrideTable;

        /* 0x0C0 */ public bool ActivateLocatorsFromRarity;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x0C1 */ public byte[] PaddingC1;
        [NMS(Size = 0x3)]
        /* 0x0C8 */ public NMSString0x10[] RarityLocators;

        /* 0x0F8 */ public bool UseSystemColorsForTexture;
        /* 0x0F9 */ public bool RemoveModel;
        /* 0x0FA */ public bool HideModel;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x0FB */ public byte[] PaddingFB;
        [NMS(Size = 0x80)]
        /* 0x0FC */ public TkTextureResource DestroyedModel;
        /* 0x180 */ public bool DestroyedModelUsesScale;
        /* 0x181 */ public bool DestroyedModelCollidesWithEverything;
        /* 0x184 */ public float DestroyForce;
        /* 0x188 */ public float DestroyForceRadius;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x18C */ public byte[] Padding18C;
        [NMS(Size = 0x10)]
        /* 0x190 */ public string DestroyEffect;
        [NMS(Size = 0x10)]
        /* 0x1A0 */ public string DestroyEffectPoint;
        /* 0x1B0 */ public float DestroyEffectTime;
        /* 0x1B4 */ public bool DestroyEffectMatrices;
        [NMS(Size = 3, Ignore = true)]
        /* 0x1B5 */ public byte[] Padding1B5;
        [NMS(Size = 0x10)]
        /* 0x1B8 */ public string AreaDamage;
        /* 0x1C8 */ public bool ShowInteract;
        /* 0x1CC */ public float ShowInteractRange;
        /* 0x1D0 */ public bool GrenadeSingleHit;

        [NMS(Size = 7, Ignore = true)]
        /* 0x1D0 */ public byte[] EndPadding;
    }
}
