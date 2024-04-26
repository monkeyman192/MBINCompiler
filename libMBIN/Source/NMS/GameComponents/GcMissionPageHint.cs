namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5A9470A1AD0937EF, NameHash = 0xBC45706D394C0853)]
    public class GcMissionPageHint : NMSTemplate
    {
        // size: 0xD
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
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MissionPageHintEnum MissionPageHint;
    }
}
