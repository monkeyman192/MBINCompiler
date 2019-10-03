using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE837A1764D2B2315, NameHash = 0xD3E5CFFA024865D7)]
    public class GcMissionConditionIsSurveying : NMSTemplate
    {
        public enum ForHotspotTypeEnum { Any, Power, Gas, Minerals }
        public ForHotspotTypeEnum ForHotspotType;
        public bool RequireAlreadyAnalysed;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
