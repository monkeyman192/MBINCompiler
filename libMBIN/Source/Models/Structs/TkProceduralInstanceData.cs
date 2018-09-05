namespace libMBIN.Models.Structs
{
    public class TkProceduralInstanceData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public int Index;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
