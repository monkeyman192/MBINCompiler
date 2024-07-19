using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA37AA1B50F685D7D, NameHash = 0xE9D08BD5)]
    public class GcShipAICombatDefinition : NMSTemplate
    {
        [NMS(Index = 15)]
        /* 0x00 */ public TkTextureResource Icon;
        [NMS(Index = 1)]
        /* 0x18 */ public NMSString0x10 Behaviour;
        [NMS(Index = 9)]
        /* 0x28 */ public NMSString0x10 DamageMultiplier;
        [NMS(Index = 3)]
        /* 0x38 */ public NMSString0x10 Engine;
        [NMS(Index = 13)]
        /* 0x48 */ public NMSString0x10 Gun;
        [NMS(Index = 0)]
        /* 0x58 */ public NMSString0x10 Id;
        [NMS(Index = 2)]
        /* 0x68 */ public NMSString0x10 PlanetBehaviour;
        [NMS(Index = 4)]
        /* 0x78 */ public NMSString0x10 PlanetEngine;
        [NMS(Index = 5)]
        /* 0x88 */ public NMSString0x10 Reward;
        [NMS(Index = 10)]
        /* 0x98 */ public NMSString0x10 Shield;
        [NMS(Index = 7)]
        /* 0xA8 */ public int Health;
        [NMS(Index = 14)]
        /* 0xAC */ public int LaserDamageLevel;
        [NMS(Index = 8)]
        /* 0xB0 */ public int LevelledExtraHealth;
        [NMS(Index = 6)]
        /* 0xB4 */ public int RewardCount;
        [NMS(Index = 12)]
        /* 0xB8 */ public bool UsesFuelRods;
        [NMS(Index = 11)]
        /* 0xB9 */ public bool UsesShieldGenerators;
    }
}
