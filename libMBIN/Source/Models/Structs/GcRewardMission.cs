namespace libMBIN.Models.Structs
{
    public class GcRewardMission : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Mission;
        public bool SetAsSelected;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
