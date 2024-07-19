namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE4FDDBB5F69B5771, NameHash = 0x6936210F)]
    public class GcJourneyMedalType : NMSTemplate
    {
        // size: 0xA
        public enum MedalTypeEnum : uint {
            Standings,
            Missions,
            Words,
            Systems,
            Sentinels,
            Pirates,
            Plants,
            Units,
            RaceCreatures,
            DistanceWarped,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MedalTypeEnum MedalType;
    }
}
