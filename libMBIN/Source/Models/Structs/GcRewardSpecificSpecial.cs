namespace libMBIN.Models.Structs
{
    public class GcRewardSpecificSpecial : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ID;
        [NMS(Size = 0x20)]
        public string Message;
    }
}
