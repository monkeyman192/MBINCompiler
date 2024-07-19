namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x84054D993BC6A79E, NameHash = 0x241A36BA)]
    public class GcRewardSignalScan : NMSTemplate
    {
        // size: 0x8
        public enum SignalScanTypeEnum : uint {
            None,
            DropPod,
            Shelter,
            Search,
            Relic,
            Industrial,
            Alien,
            CrashedFreighter,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SignalScanTypeEnum SignalScanType;
    }
}
