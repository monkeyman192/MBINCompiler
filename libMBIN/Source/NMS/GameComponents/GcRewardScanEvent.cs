using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, Size = 0x28, GUID = 0x2017578008666A3E, NameHash = 0xD6D2BF5DDCCD9F49)]
    public class GcRewardScanEvent : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Event;
		public enum ScanEventTableEnum { Space, Planet, Missions, Tutorial, MissionsCreative, NPCPlanetSite }
		public ScanEventTableEnum ScanEventTable;
        public bool DoAerialScan;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
