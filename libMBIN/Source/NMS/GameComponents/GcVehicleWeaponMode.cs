namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5B36841855E633C5, NameHash = 0x73944F97)]
    public class GcVehicleWeaponMode : NMSTemplate
    {
        // size: 0x5
        public enum VehicleWeaponModeEnum : uint {
            Laser,
            Gun,
            TerrainEdit,
            StunGun,
            Flamethrower,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public VehicleWeaponModeEnum VehicleWeaponMode;
    }
}
