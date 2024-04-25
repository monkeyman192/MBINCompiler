using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x48F0C8591D917A73, NameHash = 0x2BA616233E287BB2)]
    public class GcVehicleMuzzleData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(GcVehicleWeaponMode.VehicleWeaponModeEnum))]
        /* 0x0 */ public NMSString0x10[] MuzzleFlashDataID;
    }
}
