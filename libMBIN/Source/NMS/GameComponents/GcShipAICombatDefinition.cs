using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x100, GUID = 0x784B7C716DC456EA, NameHash = 0x27F13746A084A731)]
    public class GcShipAICombatDefinition : NMSTemplate       // size: 0x100
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public NMSString0x10 Behaviour;
        /* 0x20 */ public NMSString0x10 Engine;
        /* 0x30 */ public NMSString0x10 PlanetBehaviour;
        /* 0x40 */ public NMSString0x10 PlanetEngine;
        /* 0x50 */ public NMSString0x10 Reward;
        /* 0x60 */ public int RewardCount;
        /* 0x64 */ public int Health;
        /* 0x68 */ public NMSString0x10 Gun;
        /* 0x78 */ public int LaserDamageLevel;
        /* 0x7C */ public TkTextureResource Icon;

    }
}