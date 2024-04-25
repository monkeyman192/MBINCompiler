namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x363A8B85A41FFE28, NameHash = 0xA5FDDD239156B452)]
    public class GcTechnologyCategory : NMSTemplate
    {
        // size: 0x10
        public enum TechnologyCategoryEnum : uint {
            Ship,
            Weapon,
            Suit,
            Personal,
            All,
            None,
            Freighter,
            Maintenance,
            Exocraft,
            Submarine,
            Mech,
            AllVehicles,
            AlienShip,
            AllShips,
            RobotShip,
            AllShipsExceptAlien,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public TechnologyCategoryEnum TechnologyCategory;
    }
}
