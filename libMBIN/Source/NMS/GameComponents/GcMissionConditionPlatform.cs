namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB43D8FE704FE11A9, NameHash = 0xC2ACC280)]
    public class GcMissionConditionPlatform : NMSTemplate
    {
        // size: 0x2
        public enum MissionPlatformEnum : uint {
            Undefined,
            NintendoSwitch,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MissionPlatformEnum MissionPlatform;
    }
}