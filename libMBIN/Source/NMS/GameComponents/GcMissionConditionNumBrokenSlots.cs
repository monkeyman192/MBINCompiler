using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x77E0245571D5C391, NameHash = 0x7725C806)]
    public class GcMissionConditionNumBrokenSlots : NMSTemplate
    {
        // size: 0x3
        public enum InventoryToTestEnum : uint {
            Ship,
            ShipTech,
            Weapon,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InventoryToTestEnum InventoryToTest;
        [NMS(Index = 1)]
        /* 0x4 */ public int NumberOfBrokenSlots;
        [NMS(Index = 2)]
        /* 0x8 */ public TkEqualityEnum Test;
    }
}
