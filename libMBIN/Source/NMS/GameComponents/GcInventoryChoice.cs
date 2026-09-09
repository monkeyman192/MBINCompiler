namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2D2EC3AD0F429EFA, NameHash = 0xFA725F6D)]
    public class GcInventoryChoice : NMSTemplate
    {
        // size: 0x21
        public enum InventoryChoiceEnum : uint {
            Personal,
            Personal_TechOnly,
            Personal_Cargo,
            Weapon,
            Ship,
            Ship_TechOnly,
            Ship_Cargo,
            Freighter,
            Freighter_TechOnly,
            Freighter_Cargo,
            Vehicle,
            Vehicle_TechOnly,
            Chest1,
            Chest2,
            Chest3,
            Chest4,
            Chest5,
            Chest6,
            Chest7,
            Chest8,
            Chest9,
            Chest10,
            ChestMagic,
            ChestMagic2,
            MaintenanceObject,
            FrontendPage,
            CookingIngredients,
            RocketLocker,
            SeasonTransfer,
            FishPlatform,
            FishBaitBox,
            FoodUnit,
            CorvetteParts,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InventoryChoiceEnum InventoryChoice;
    }
}
