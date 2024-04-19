using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x57AA65E33D1B7E3, NameHash = 0x27F13746A084A731)]
    public class GcShipAICombatDefinition : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Behaviour;
        /* 0x010 */ public NMSString0x10 DamageMultiplier;
        /* 0x020 */ public NMSString0x10 Engine;
        /* 0x030 */ public NMSString0x10 Gun;
        /* 0x040 */ public NMSString0x10 Id;
        /* 0x050 */ public NMSString0x10 PlanetBehaviour;
        /* 0x060 */ public NMSString0x10 PlanetEngine;
        /* 0x070 */ public NMSString0x10 Reward;
        /* 0x080 */ public NMSString0x10 Shield;
        /* 0x090 */ public TkTextureResource Icon;
        /* 0x114 */ public int Health;
        /* 0x118 */ public int LaserDamageLevel;
        /* 0x11C */ public int LevelledExtraHealth;
        /* 0x120 */ public int RewardCount;
        /* 0x124 */ public bool UsesFuelRods;
        /* 0x125 */ public bool UsesShieldGenerators;
    }
}
