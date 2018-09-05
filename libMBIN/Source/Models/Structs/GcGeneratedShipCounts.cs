namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x18)]
    public class GcGeneratedShipCounts : NMSTemplate
    {
        [NMS(Size = 0x6)]
        public int[] Counts;
    }
}