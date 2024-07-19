namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA6355357C115C555, NameHash = 0x5179E0DF)]
    public class GcSpaceshipClasses : NMSTemplate
    {
        // size: 0xA
        public enum ShipClassEnum : uint {
            Freighter,
            Dropship,
            Fighter,
            Scientific,
            Shuttle,
            PlayerFreighter,
            Royal,
            Alien,
            Sail,
            Robot,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ShipClassEnum ShipClass;
    }
}
