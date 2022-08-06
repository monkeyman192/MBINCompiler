using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x582A505F8DEDDEC2, NameHash = 0xDB998DBB6155E40C)]
    public class GcMissionConditionHasGalacticFeature : NMSTemplate
    {
        public GcMissionGalacticFeature Type;
    }
}