namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x673C5C3351471A1C, NameHash = 0xE3BDE57931D2177D)]
    public class GcVehicleWeaponMode : NMSTemplate
    {
        // size: 0x4
        public enum VehicleWeaponModeEnum : uint {
            Laser,
            Gun,
            TerrainEdit,
            StunGun,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public VehicleWeaponModeEnum VehicleWeaponMode;
    }
}
