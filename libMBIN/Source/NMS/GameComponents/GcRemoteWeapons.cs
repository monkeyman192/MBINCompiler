namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6ED6004B37ACA274, NameHash = 0x31EDDDE2)]
    public class GcRemoteWeapons : NMSTemplate
    {
        // size: 0x17
        public enum RemoteWeaponTypeEnum : uint {
            Laser,
            VehicleLaser,
            AIMechLaser,
            ShipLaser,
            ShipLaser2,
            RailLaser,
            NumLasers,
            BoltCaster,
            Shotgun,
            Cannon,
            Burst,
            Flamethrower,
            MineGrenade,
            BounceGrenade,
            StunGrenade,
            VehicleCanon,
            AIMechCanon,
            ShipPhoton,
            ShipShotgun,
            ShipMinigun,
            ShipPlasma,
            ShipRocket,
            None,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public RemoteWeaponTypeEnum RemoteWeaponType;
    }
}
