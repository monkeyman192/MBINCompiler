using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCB1F989A6B6027F, NameHash = 0x9D1165409EC6DFE7)]
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
