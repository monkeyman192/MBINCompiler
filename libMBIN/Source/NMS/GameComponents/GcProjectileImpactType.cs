using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF49F5BA11978F4EC, NameHash = 0xC652A220FFABA4FE)]
    public class GcProjectileImpactType : NMSTemplate
    {
        // size: 0x11
        public enum ImpactEnum { Default, Terrain, Substance, Rock, Asteroid, Shield, Creature, Robot, Freighter,
            Cargo, Ship, Plant, NeedsTech, Player, OtherPlayer, SentinelShield,
            SpaceshipShield
        }
        /* 0x0 */ public ImpactEnum Impact;
    }
}
