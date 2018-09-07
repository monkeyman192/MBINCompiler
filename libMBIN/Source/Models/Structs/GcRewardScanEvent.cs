namespace libMBIN.Models.Structs
{
    public class GcRewardScanEvent : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Event;
		public enum ScanEventTableEnum { Space, Planet, Missions, Tutorial }
		public ScanEventTableEnum ScanEventTable;
    }
}
