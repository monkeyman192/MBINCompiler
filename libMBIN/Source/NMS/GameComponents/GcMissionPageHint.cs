namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D027935D44AB63, NameHash = 0x400FBCF9)]
    public class GcMissionPageHint : NMSTemplate
    {
        // size: 0xF
        public enum MissionPageHintEnum : uint {
            None,
            Suit,
            Ship,
            Weapon,
            Vehicle,
            Freighter,
            Wiki,
            Catalogue,
            MissionLog,
            Discovery,
            Journey,
            Expedition,
            Options,
            Pets,
            SolarSystemMap,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MissionPageHintEnum MissionPageHint;
    }
}
