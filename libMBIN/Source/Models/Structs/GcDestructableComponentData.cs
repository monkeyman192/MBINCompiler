using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x148)]
    public class GcDestructableComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Explosion;
        /* 0x010 */ public float ExplosionScale;
        /* 0x014 */ public bool ExplosionScaleToBounds;
        [NMS(Size = 3, Ignore = true)]
        /* 0x015 */ public byte[] Padding15;

        [NMS(Size = 0x10)]
        /* 0x018 */public string VehicleDestroyEffect;

        [NMS(Size = 0x10)]
        /* 0x028 */ public string TriggerAction;
        /* 0x038 */ public int IncreaseWanted;
        [NMS(Size = 4, Ignore = true)]
        /* 0x03C */ public byte[] Padding3C;

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

        /* 0x084 */ public bool RemoveModel;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x085 */ public byte[] Padding85;
        [NMS(Size = 0x80)]
        /* 0x088 */ public TkTextureResource DestroyedModel;
        /* 0x10C */ public bool DestroyedModelUsesScale;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x10D */public byte[] Padding10D;
        /* 0x110 */ public float DestroyForce;
        /* 0x114 */ public float DestroyForceRadius;
        [NMS(Size = 0x10)]
        /* 0x118 */ public string DestroyEffect;
        [NMS(Size = 0x10)]
        /* 0x128 */ public string DestroyEffectPoint;
        /* 0x138 */ public float DestroyEffectTime;

        /* 0x13C */ public bool ShowInteract;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x13D */ public byte[] Padding13D;
        /* 0x140 */ public float ShowInteractRange;
        /* 0x144 */ public bool GrenadeSingleHit;

        [NMS(Size = 3, Ignore = true)]
        /* 0x145 */ public byte[] Padding145;
    }
}
