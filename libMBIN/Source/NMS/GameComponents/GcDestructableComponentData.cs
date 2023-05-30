using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
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

        /* 0x068 */ public bool RemoveModel;
        /* 0x06C */ public TkModelResource DestroyedModel;
        /* 0x0F0 */ public bool DestroyedModelUsesScale;
        /* 0x0F4 */ public float DestroyForce;
        /* 0x0F8 */ public float DestroyForceRadius;
        /* 0x100 */ public List<NMSString0x10> DestroyEffectPoints;
        /* 0x110 */ public float DestroyEffectTime;

        /* 0x114 */ public bool ShowInteract;
        /* 0x118 */ public float ShowInteractRange;
        /* 0x11C */ public bool GrenadeSingleHit;

        [NMS(Size = 3, Ignore = true)]
        /* 0x11D */ public byte[] Padding11D;
    }
}
