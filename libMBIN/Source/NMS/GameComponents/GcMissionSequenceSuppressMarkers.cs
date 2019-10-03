using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2, GUID = 0x63B637B58BC0169C, NameHash = 0x18AA3675C5404DBD)]
    public class GcMissionSequenceSuppressMarkers : NMSTemplate
    {
        public bool Suppressed;
        public bool SuppressedAfterNextWarp;
    }
}
