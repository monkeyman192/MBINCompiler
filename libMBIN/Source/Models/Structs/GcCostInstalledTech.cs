namespace libMBIN.Models.Structs
{
    public class GcCostInstalledTech : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
		
        public int InvetoryToCheck;
		public enum InventoryToCheckEnum { All, Suit, Ship, Weapon, Freighter, Buggy }
		public InventoryToCheckEnum InventoryToCheck;
    }
}
