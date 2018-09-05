namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x58)]
    public class GcPlayerCommunicatorMessageWeighted : NMSTemplate
    {
        public GcPlayerCommunicatorMessage Message;
        public int Weighted;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
