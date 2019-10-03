using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x198, Alignment = 0x8, GUID = 0x54C989BE7DFF4078, NameHash = 0xE24B3D78ED0634BD)]
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

        /* 0x68 */ public GcStatsEnum StatsToTrack;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x6C */ public byte[] Padding6C;

        [NMS(Size = 0x10)]
        /* 0x070 */ public string GivesReward;
		/* 0x080 */ public float HardModeSubstanceMultiplier;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x084 */ public byte[] Padding84;

        /* 0x088 */ public List<GcRewardMissionOverride> RewardOverrideTable;

        /* 0x098 */ public bool ActivateLocatorsFromRarity;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x099 */ public byte[] Padding99;
        [NMS(Size = 0x3)]
        /* 0x0A0 */ public NMSString0x10[] RarityLocators;

        /* 0x0D0 */ public bool UseSystemColorsForTexture;
        /* 0x0D1 */ public bool RemoveModel;
        /* 0x0D2 */ public bool HideModel;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x0D3 */ public byte[] PaddingD3;
        [NMS(Size = 0x80)]
        /* 0x0D4 */ public TkTextureResource DestroyedModel;
        /* 0x158 */ public bool DestroyedModelUsesScale;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x159 */ public byte[] Padding159;
        /* 0x15C */ public float DestroyForce;
        /* 0x160 */ public float DestroyForceRadius;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x164 */ public byte[] Padding164;
        [NMS(Size = 0x10)]
        /* 0x168 */ public string DestroyEffect;
        [NMS(Size = 0x10)]
        /* 0x178 */ public string DestroyEffectPoint;
        /* 0x188 */ public float DestroyEffectTime;

        /* 0x18C */ public bool DestroyEffectMatrices;
        /* 0x18D */ public bool ShowInteract;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x18E */ public byte[] Padding18E;
        /* 0x190 */ public float ShowInteractRange;
        /* 0x194 */ public bool GrenadeSingleHit;

        [NMS(Size = 3, Ignore = true)]
        /* 0x195 */ public byte[] EndPadding;
    }
}
