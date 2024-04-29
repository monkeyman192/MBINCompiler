using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1BEB35E09AE552B8, NameHash = 0x27F13746A084A731)]
    public class GcShipAICombatDefinition : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public NMSString0x10 Behaviour;
        [NMS(Index = 9)]
        /* 0x010 */ public NMSString0x10 DamageMultiplier;
        [NMS(Index = 3)]
        /* 0x020 */ public NMSString0x10 Engine;
        [NMS(Index = 13)]
        /* 0x030 */ public NMSString0x10 Gun;
        [NMS(Index = 0)]
        /* 0x040 */ public NMSString0x10 Id;
        [NMS(Index = 2)]
        /* 0x050 */ public NMSString0x10 PlanetBehaviour;
        [NMS(Index = 4)]
        /* 0x060 */ public NMSString0x10 PlanetEngine;
        [NMS(Index = 5)]
        /* 0x070 */ public NMSString0x10 Reward;
        [NMS(Index = 10)]
        /* 0x080 */ public NMSString0x10 Shield;
        [NMS(Index = 15)]
        /* 0x090 */ public TkTextureResource Icon;
        [NMS(Index = 7)]
        /* 0x114 */ public int Health;
        [NMS(Index = 14)]
        /* 0x118 */ public int LaserDamageLevel;
        [NMS(Index = 8)]
        /* 0x11C */ public int LevelledExtraHealth;
        [NMS(Index = 6)]
        /* 0x120 */ public int RewardCount;
        [NMS(Index = 12)]
        /* 0x124 */ public bool UsesFuelRods;
        [NMS(Index = 11)]
        /* 0x125 */ public bool UsesShieldGenerators;
    }
}
