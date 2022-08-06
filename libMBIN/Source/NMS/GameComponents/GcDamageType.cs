using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2AD93678DE45DF5F, NameHash = 0xCD0F83EA324443E1)]
    public class GcDamageType : NMSTemplate
    {
        // size: 0x17
        public enum DamageTypeEnum { Gun, Laser, Shotgun, Burst, Rail, Cannon, Explosion, Melee, ShipGun, ShipLaser,
            ShipShotgun, ShipMinigun, ShipRockets, ShipPlasma, VehicleGun,
            VehicleLaser, SentinelLaser, PlayerDamage, PlayerWeapons, ShipWeapons,
            VehicleWeapons, CombatEffects, Fiend
        }
        /* 0x0 */ public DamageTypeEnum DamageType;
    }
}
