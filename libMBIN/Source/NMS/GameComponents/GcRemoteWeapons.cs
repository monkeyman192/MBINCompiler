using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x486A8F14DBD58528, NameHash = 0x3239FD75543805A7)]
    public class GcRemoteWeapons : NMSTemplate
    {
        // size: 0x16
        public enum RemoteWeaponTypeEnum { Laser, VehicleLaser, AIMechLaser, ShipLaser, ShipLaser2, RailLaser, NumLasers,
            BoltCaster, Shotgun, Cannon, Burst, MineGrenade, BounceGrenade,
            StunGrenade, VehicleCanon, AIMechCanon, ShipPhoton, ShipShotgun, ShipMinigun,
            ShipPlasma, ShipRocket, None
        }
        /* 0x0 */ public RemoteWeaponTypeEnum RemoteWeaponType;
    }
}
