using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCE38DEF3407C922D, NameHash = 0x19721C21)]
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
