namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x38)]
    public class TkInteractiveControlData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Id;
        [NMS(Size = 0x10)]
        public string RewardId;
        public float Cooldown;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
