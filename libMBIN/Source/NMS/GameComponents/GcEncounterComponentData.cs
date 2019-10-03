using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x52049EC71382D2EC, NameHash = 0x1BAD68301EABDA5C)]
    public class GcEncounterComponentData : NMSTemplate
    {
		public enum EncounterTypeEnum { FactoryGuards, HarvesterGuards, ScrapHeap }
		public EncounterTypeEnum EncounterType;
    }
}
