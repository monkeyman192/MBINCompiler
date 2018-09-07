namespace libMBIN.Models.Structs
{
    public class GcSpaceshipClasses : NMSTemplate
    {
		public enum ShipClassEnum { Freighter, Dropship, Fighter, Scientific, Shuttle, PlayerFreighter, Royal }
		public ShipClassEnum ShipClass;
    }
}
