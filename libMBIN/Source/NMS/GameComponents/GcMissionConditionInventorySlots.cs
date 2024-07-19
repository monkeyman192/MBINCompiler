using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB3A5696E9169EB9C, NameHash = 0x7CC294EF)]
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
        [NMS(Index = 0)]
        /* 0x00 */ public InventoryTestEnum InventoryTest;
        [NMS(Index = 2)]
        /* 0x04 */ public int SlotsFree;
        // size: 0x2
        public enum SlotTypeEnum : uint {
            FreeSlot,
            BrokenSlot,
        }
        [NMS(Index = 1)]
        /* 0x08 */ public SlotTypeEnum SlotType;
        [NMS(Index = 3)]
        /* 0x0C */ public TkEqualityEnum Test;
        [NMS(Index = 4)]
        /* 0x10 */ public bool TestAllSlotsUnlocked;
        [NMS(Index = 5)]
        /* 0x11 */ public bool TestOnlyMainInventory;
    }
}
