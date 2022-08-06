using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x87544BCF24578A79, NameHash = 0xA4091406380F5113)]
    public class GcGenericIconTypes : NMSTemplate
    {
		// size: 0x6
        public enum GenericIconTypeEnum { None, Interaction, SpaceStation, SpaceAnomaly, SpaceAtlas, Nexus }
		public GenericIconTypeEnum GenericIconType;
    }
}