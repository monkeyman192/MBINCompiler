using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x25B610E77FEBCEA1, NameHash = 0xC88FD2BBB93553F9)]
    public class GcPerformanceGuard : NMSTemplate
    {
        public float Radius;
        public GcEncounterComponentData Encounter;
    }
}
