using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE12FCC23D50B7756, NameHash = 0x748F2F6EDE9F5F18)]
    public class GcBuildingOverrideData : NMSTemplate
    {
        public GcSeed Seed;
        public Vector3f Position;
        public int Index;
    }
}
