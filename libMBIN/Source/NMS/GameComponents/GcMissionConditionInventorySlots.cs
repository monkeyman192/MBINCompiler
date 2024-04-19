using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9B1B6E8E8F3CD8F2, NameHash = 0xF112AB8FC14A734A)]
    public class GcMissionConditionInventorySlots : NMSTemplate
    {
        // size: 0x5
        public enum InventoryTestEnum : uint {
            Current,
            Personal,
            Ship,
            Vehicle,
            Weapon,
        }
        /* 0x00 */ public InventoryTestEnum InventoryTest;
        /* 0x04 */ public int SlotsFree;
        // size: 0x2
        public enum SlotTypeEnum : uint {
            FreeSlot,
            BrokenSlot,
        }
        /* 0x08 */ public SlotTypeEnum SlotType;
        /* 0x0C */ public TkEqualityEnum Test;
        /* 0x10 */ public bool TestAllSlotsUnlocked;
        /* 0x11 */ public bool TestOnlyMainInventory;
    }
}
