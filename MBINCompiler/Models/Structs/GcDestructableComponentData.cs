using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcDestructableComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Explosion;
        /* 0x010 */ public float ExplosionScale;
        [NMS(Size = 4, Ignore = true)]
        /* 0x014 */ public byte[] Padding14;

        [NMS(Size = 0x10)]
        /* 0x018 */ public string TriggerAction;
        /* 0x028 */ public int IncreaseWanted;
        [NMS(Size = 4, Ignore = true)]
        /* 0x02C */ public byte[] Padding2C;

        [NMS(Size = 0x10)]
        /* 0x030 */ public string LootReward;

        /* 0x040 */ public int LootRewardAmountMin;
        /* 0x044 */ public int LootRewardAmountMax;

        /* 0x048 */ public List<GcSubstanceAmount> GivesSubstances;
        [NMS(Size = 0x10)]
        /* 0x058 */ public string GivesReward;
		/* 0x068 */ public float HardModeSubstanceMultiplier;

        /* 0x06C */ public bool RemoveModel;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x06D */ public byte[] Padding6D;
        [NMS(Size = 0x80)]
        /* 0x070 */ public string DestroyedModel;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0F0 */ public byte[] PaddingF0;
        /* 0x0F4 */ public bool DestroyedModelUsesScale;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x0F5 */public byte[] PaddingF5;
        /* 0x0F8 */ public float DestroyForce;
        /* 0x0FC */ public float DestroyForceRadius;
        [NMS(Size = 0x10)]
        /* 0x100 */ public string DestroyEffect;
        [NMS(Size = 0x10)]
        /* 0x110 */ public string DestroyEffectPoint;
        /* 0x120 */ public float DestroyEffectTime;

        /* 0x124 */ public bool ShowInteract;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x125 */ public byte[] Padding125;
        /* 0x128 */ public float ShowInteractRange;
        /* 0x12C */ public bool GrenadeSingleHit;

        [NMS(Size = 3, Ignore = true)]
        /* 0x12D */ public byte[] Padding12D;
    }
}
