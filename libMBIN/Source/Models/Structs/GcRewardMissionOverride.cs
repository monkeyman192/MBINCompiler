namespace libMBIN.Models.Structs
{
    public class GcRewardMissionOverride : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Mission;
        [NMS(Size = 0x10)]
        public string Reward;
    }
}
