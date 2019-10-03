using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x39A24470DAF09705, NameHash = 0xC88FD2BBB93553F9)]
    public class GcPerformanceGuard : NMSTemplate
    {
        public float Radius;            // 42480000h
        public GcSizeIndicator Encounter;
    }
}
