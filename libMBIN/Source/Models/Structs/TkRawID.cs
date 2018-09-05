namespace libMBIN.Models.Structs
{
    public class TkRawID : NMSTemplate
    {
        [NMS(Size = 0x8)]
        public string Value0;
        public ulong Value1;
    }
}
