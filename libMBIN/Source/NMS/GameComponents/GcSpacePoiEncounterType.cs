namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB62978F952C62A2E, NameHash = 0x731423F8)]
    public class GcSpacePoiEncounterType : NMSTemplate
    {
        // size: 0x6
        public enum SpacePoiEncounterTypeEnum : uint {
            NoEncounter,
            SpaceHostiles,
            TraderHail,
            AmbientTraders,
            Miners,
            Frigate,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SpacePoiEncounterTypeEnum SpacePoiEncounterType;
    }
}
