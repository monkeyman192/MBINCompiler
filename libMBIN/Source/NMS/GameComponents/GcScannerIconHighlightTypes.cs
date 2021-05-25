using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x5CC4805D05B121FD, NameHash = 0x1E73CF8A2A7FA65D)]
    public class GcScannerIconHighlightTypes : NMSTemplate
    {
        // size: 0x5
		public enum ScannerIconHighlightTypeEnum { Diamond, Hexagon, Tag, Octagon, Circle }
		public ScannerIconHighlightTypeEnum ScannerIconHighlightType;
    }
}