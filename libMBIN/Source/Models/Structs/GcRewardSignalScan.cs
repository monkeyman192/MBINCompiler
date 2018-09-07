namespace libMBIN.Models.Structs
{
    public class GcRewardSignalScan : NMSTemplate
    {
		public enum SignalScanTypeEnum { None, DropPod, Shelter, Search, Relic, Industrial, Alien, CrashedFreighter }
		public SignalScanTypeEnum SignalScanType;
    }
}
