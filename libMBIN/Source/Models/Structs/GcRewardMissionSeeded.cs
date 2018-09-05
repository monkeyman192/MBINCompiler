namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x10)]
    public class GcRewardMissionSeeded : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Mission;
        [NMS(Size = 0x10)]
        public string MissionCreative;
    }
}
