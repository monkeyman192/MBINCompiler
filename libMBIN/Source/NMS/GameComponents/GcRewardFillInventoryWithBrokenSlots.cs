namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD945A13D96E16B2, NameHash = 0x15BF5AB9B072AD3)]
    public class GcRewardFillInventoryWithBrokenSlots : NMSTemplate
    {
        /* 0x00 */ public int CustomTechCount;
        /* 0x04 */ public int CustomTechOffset;
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
        /* 0x0C */ public InventoryToBreakEnum InventoryToBreak;
        /* 0x10 */ public NMSString0x20 CustomTechFormat;
    }
}
