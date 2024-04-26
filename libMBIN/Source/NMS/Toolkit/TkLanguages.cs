namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x370D5A3B36E0E0F1, NameHash = 0xEA37791FF01A5AF4)]
    public class TkLanguages : NMSTemplate
    {
        // size: 0x12
        public enum LanguageEnum : uint {
            Default,
            English,
            USEnglish,
            French,
            Italian,
            German,
            Spanish,
            Russian,
            Polish,
            Dutch,
            Portuguese,
            LatinAmericanSpanish,
            BrazilianPortuguese,
            Japanese,
            TraditionalChinese,
            SimplifiedChinese,
            TencentChinese,
            Korean,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public LanguageEnum Language;
    }
}
