using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcSolarSystemLocatorChoice : NMSTemplate
    {
        public int Choice;
        public string[] ChoiceValues()
        {
            return new[] { "LookupName", "AnyOfType", "SpecificIndex", "InFrontOfPlayer" };
        }

        public NMSString0x20 Name; // 0x20
        public GcSolarSystemLocatorTypes LocatorType;
        public int Index;
    }
}
