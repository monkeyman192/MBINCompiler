using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFCC48A5DDF4D778C, NameHash = 0x84B1F1D780A31A2A)]
    public class GcSolarSystemLocatorChoice : NMSTemplate
    {
        // size: 0x4
        public enum ChoiceEnum : uint {
            LookupName,
            AnyOfType,
            SpecificIndex,
            InFrontOfPlayer,
        }
        /* 0x0 */ public ChoiceEnum Choice;
        /* 0x4 */ public int Index;
        /* 0x8 */ public GcSolarSystemLocatorTypes Type;
        /* 0xC */ public NMSString0x20 Name;
    }
}
