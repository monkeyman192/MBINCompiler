using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA21378A248765720, NameHash = 0x8A35BC3F94D0949F)]
    public class GcPunctuationDelayTable : NMSTemplate
    {
        // size: 0x6
        public enum PunctuationDelaysEnum {
            Default,
            Gek,
            Korvax,
            Vykeen,
            FourthRace,
            Builders,
        }
        [NMS(Index = 0, Size = 0x6, EnumType = typeof(PunctuationDelaysEnum))]
        /* 0x0 */ public GcPunctuationDelayData[] PunctuationDelays;
    }
}
