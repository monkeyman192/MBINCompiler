namespace libMBIN.Models.Structs
{
    public class GcExpeditionDurationValues : NMSTemplate
    {
        [NMS(Size = 0x5)]
        public int[] Duration;
    }
}
