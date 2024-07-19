namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x40D2D9150DBBFB0E, NameHash = 0xFCEE2998)]
    public class GcMissionCategory : NMSTemplate
    {
        // size: 0x5
        public enum MissionCategoryEnum : uint {
            Info,
            SelectableHint,
            Mission,
            Danger,
            Urgent,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MissionCategoryEnum MissionCategory;
    }
}
