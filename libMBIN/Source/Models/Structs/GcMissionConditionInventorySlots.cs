namespace libMBIN.Models.Structs
{
    public class GcMissionConditionInventorySlots : NMSTemplate
    {
		public enum InventoryTestEnum { Current, personal, Ship, Vehicle }
		public InventoryTestEnum InventoryTest;
        public int SlotsFree;
        public TkEqualityEnum Test;
    }
}
