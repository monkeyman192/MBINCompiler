using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x784B7C716DC456EA, NameHash = 0x27F13746A084A731)]
    public class GcShipAICombatDefinition : NMSTemplate       // size: 0x100
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string Behaviour;
        [NMS(Size = 0x10)]
        /* 0x20 */ public string Engine;
        [NMS(Size = 0x10)]
        /* 0x30 */ public string PlanetBehaviour;
        [NMS(Size = 0x10)]
        /* 0x40 */ public string PlanetEngine;
        [NMS(Size = 0x10)]
        /* 0x50 */ public string Reward;
        /* 0x60 */ public int RewardCount;
        /* 0x64 */ public int Health;
        [NMS(Size = 0x10)]
        /* 0x68 */ public string Gun;
        /* 0x78 */ public int LaserDamageLevel;
        /* 0x7C */ public TkTextureResource Icon;

    }
}
