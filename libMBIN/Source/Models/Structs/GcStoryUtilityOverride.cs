namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x30)]
    public class GcStoryUtilityOverride : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Name;
        [NMS(Size = 0x10)]
        public string Reward;
    }
}
