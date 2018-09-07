namespace libMBIN.Models.Structs
{
    public class GcBuildingCostPartCount : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public int Count;

        [NMS( Size = 0x04, Ignore = true )]
        public byte[] Padding14;
    }
}
