using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9876B949FCE1EA5B, NameHash = 0x84B1F1D780A31A2A)]
    public class GcSolarSystemLocatorChoice : NMSTemplate       // size: 0x2C
    {
		public enum ChoiceEnum { LookupName, AnyOfType, SpecificIndex, InFrontOfPlayer }
		public ChoiceEnum Choice;

        [NMS(Size = 0x20)]
        /* 0x04 */ public string Name;
        /* 0x24 */ public GcSolarSystemLocatorTypes LocatorType;
        /* 0x28 */ public int Index;
    }
}
