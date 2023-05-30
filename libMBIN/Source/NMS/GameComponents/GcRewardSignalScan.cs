using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcRewardSignalScan : NMSTemplate
    {
        public int SignalScanType;
        public string[] SignalScanTypeValues()
        {
            return new[] { "None", "DropPod", "Shelter", "Search", "Relic", "Industrial" };
        }
    }
}
