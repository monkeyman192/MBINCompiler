namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA60AAF299570D8C, NameHash = 0x15BF5AB9B072AD3)]
    public class GcRewardFillInventoryWithBrokenSlots : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public int CustomTechCount;
        [NMS(Index = 4)]
        /* 0x04 */ public int CustomTechOffset;
        [NMS(Index = 1)]
        /* 0x08 */ public float FractionOfInventoryToBreak;
        // size: 0x7
        public enum InventoryToBreakEnum : uint {
            Ship,
            ShipTech,
            Freighter,
            FreighterTech,
            Vehicle,
            VehicleTech,
            Weapon,
        }
        [NMS(Index = 0)]
        /* 0x0C */ public InventoryToBreakEnum InventoryToBreak;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x20 CustomTechFormat;
    }
}
