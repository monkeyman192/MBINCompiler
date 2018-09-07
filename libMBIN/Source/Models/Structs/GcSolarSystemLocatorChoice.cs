namespace libMBIN.Models.Structs
{
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
