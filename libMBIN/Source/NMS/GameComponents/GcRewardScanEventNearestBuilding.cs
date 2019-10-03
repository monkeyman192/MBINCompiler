using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xFB4C5A9F89C74F2D, NameHash = 0x3D555D4C64B13971)]
    public class GcRewardScanEventNearestBuilding : NMSTemplate
    {
        public bool DoAerialScan;
        public bool IncludeVisited;
    }
}
