namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE01BE0B6BD142C64, NameHash = 0xDA426786)]
    public class GcAISpaceshipTypes : NMSTemplate
    {
        // size: 0x7
        public enum ShipTypeEnum : uint {
            None,
            Pirate,
            Police,
            Trader,
            Freighter,
            PlayerSquadron,
            DefenceForce,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ShipTypeEnum ShipType;
    }
}
