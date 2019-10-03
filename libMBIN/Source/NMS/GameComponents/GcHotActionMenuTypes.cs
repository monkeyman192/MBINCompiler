using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1BAE16556CE24834, NameHash = 0xF0C0C2FEA5315F36)]
    public class GcHotActionMenuTypes : NMSTemplate
    {
		public enum HotActionMenuTypesEnum { OnFoot, InShip, InExocraft }
		public HotActionMenuTypesEnum HotActionMenuTypes;
    }
}
