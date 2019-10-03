using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7F550CECD9352EFD, NameHash = 0x4861EEE7B04EAB00)]
    public class GcMissionConditionNumAtlasStationsVisited : NMSTemplate
    {
        public int Count;
        public TkEqualityEnum Test;
    }
}
