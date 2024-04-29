using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2D8A280626E66443, NameHash = 0x84B1F1D780A31A2A)]
    public class GcSolarSystemLocatorChoice : NMSTemplate
    {
        // size: 0x4
        public enum ChoiceEnum : uint {
            LookupName,
            AnyOfType,
            SpecificIndex,
            InFrontOfPlayer,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ChoiceEnum Choice;
        [NMS(Index = 3)]
        /* 0x4 */ public int Index;
        [NMS(Index = 2)]
        /* 0x8 */ public GcSolarSystemLocatorTypes Type;
        [NMS(Index = 1)]
        /* 0xC */ public NMSString0x20 Name;
    }
}
