using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xAB2EFFD5A99D806E, NameHash = 0xA3C86E46D2A8CA67)]
    public class GcFrigateClass : NMSTemplate
    {
		public enum FrigateClassEnum { Combat, Exploration, Mining, Diplomacy, Support }
		public FrigateClassEnum FrigateClass;
    }
}
