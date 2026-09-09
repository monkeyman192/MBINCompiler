namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x448020D5568AC612, NameHash = 0xA70D5A47)]
    public class GcMissionConditionStationOwnership : NMSTemplate
    {
        // size: 0x5
        public enum FunctionalTestEnum : uint {
            RaceStanding,
            GuildStanding,
            POIMissions,
            Units,
            All,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FunctionalTestEnum FunctionalTest;
    }
}
