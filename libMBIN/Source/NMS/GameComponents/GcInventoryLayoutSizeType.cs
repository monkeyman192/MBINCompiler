namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDF6D3D99AC1DDA5A, NameHash = 0x33060745)]
    public class GcInventoryLayoutSizeType : NMSTemplate
    {
        // size: 0x29
        public enum SizeTypeEnum : uint {
            SciSmall,
            SciMedium,
            SciLarge,
            FgtSmall,
            FgtMedium,
            FgtLarge,
            ShuSmall,
            ShtMedium,
            ShtLarge,
            DrpSmall,
            DrpMedium,
            DrpLarge,
            RoySmall,
            RoyMedium,
            RoyLarge,
            AlienSmall,
            AlienMedium,
            AlienLarge,
            SailSmall,
            SailMedium,
            SailLarge,
            RobotSmall,
            RobotMedium,
            RobotLarge,
            WeaponSmall,
            WeaponMedium,
            WeaponLarge,
            FreighterSmall,
            FreighterMedium,
            FreighterLarge,
            VehicleSmall,
            VehicleMedium,
            VehicleLarge,
            ChestSmall,
            ChestMedium,
            ChestLarge,
            ChestCapsule,
            Suit,
            MaintObject,
            RocketLocker,
            FishBaitBox,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SizeTypeEnum SizeType;
    }
}
