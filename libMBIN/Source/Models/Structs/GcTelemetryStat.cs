namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x28)]
    public class GcTelemetryStat : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        [NMS(Size = 0x10)]
        public string Type;
        public int Value;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
