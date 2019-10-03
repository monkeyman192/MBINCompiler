using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE257E78487E5727A, NameHash = 0xA4091406380F5113)]
    public class GcGenericIconTypes : NMSTemplate
    {
		public enum GenericIconTypeEnum { None, Interaction, SpaceStation, SpaceAnomaly, SpaceAtlas, Nexus }
		public GenericIconTypeEnum GenericIconType;
    }
}
