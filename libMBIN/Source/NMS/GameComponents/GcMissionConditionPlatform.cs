namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x848D691D054822BB, NameHash = 0xC2ACC280)]
    public class GcMissionConditionPlatform : NMSTemplate
    {
        // size: 0x6
        public enum MissionPlatformEnum : uint {
            Undefined,
            NintendoSwitch,
            NintendoSwitch2,
            PS4,
            PS5,
            PCButNotWinstore,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MissionPlatformEnum MissionPlatform;
    }
}
