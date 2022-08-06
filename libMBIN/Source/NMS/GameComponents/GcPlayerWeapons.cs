using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD1B978D86D9CAD03, NameHash = 0x8A17532BB2410967)]
    public class GcPlayerWeapons : NMSTemplate
    {
        // size: 0x13
        public enum WeaponModeEnum { Bolt, Shotgun, Burst, Rail, Cannon, Laser, Grenade, MineGrenade, Scope, FrontShield,
            Melee, TerrainEdit, SunLaser, Spawner, SpawnerAlt, SoulLaser,
            Flamethrower, StunGrenade, Stealth
        }
        /* 0x0 */ public WeaponModeEnum WeaponMode;
    }
}
