using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA3CCB329200133E1, NameHash = 0x889C90DB)]
    public class GcVehicleMuzzleData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcVehicleWeaponMode.VehicleWeaponModeEnum))]
        /* 0x0 */ public NMSString0x10[] MuzzleFlashDataID;
    }
}
