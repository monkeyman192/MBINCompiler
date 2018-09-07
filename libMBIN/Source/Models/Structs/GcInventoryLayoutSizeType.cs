namespace libMBIN.Models.Structs
{
    public class GcInventoryLayoutSizeType : NMSTemplate
    {
		public enum SizeTypeEnum { SciSmall, SciMedium, SciLarge, FgtSmall, FgtMedium, FgtLarge, ShtSmall, ShtMedium, ShtLarge, DrpSmall, DrpMedium, DrpLarge,
            RoySmall, RoyMedium, RoyLarge, WeaponSmall, WeaponMedium, WeaponLarge, FreighterSmall, FreighterMedium, FreighterLarge, VehicleSmall, VehicleMedium,
            VehicleLarge, ChestSmall, ChestMedium, ChestLarge, ChestCapsule }
		public SizeTypeEnum SizeType;
    }
}
