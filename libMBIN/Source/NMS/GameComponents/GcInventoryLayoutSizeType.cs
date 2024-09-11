namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1B33422173AFC92, NameHash = 0x33060745)]
    public class GcInventoryLayoutSizeType : NMSTemplate
    {
        // size: 0x2A
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
            FishingPlatform,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SizeTypeEnum SizeType;
    }
}
