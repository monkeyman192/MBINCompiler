using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x4, GUID = 0x86B61CEEE4451AD, NameHash = 0xEA37791FF01A5AF4)]
    public class TkLanguages : NMSTemplate
    {
        // size: 0x12
        public enum LanguageEnum {
            Default, English, USEnglish, French, Italian, German, Spanish, Russian, Polish, Dutch, Portuguese, LatinAmericanSpanish, BrazilianPortuguese,
            Japanese, TraditionalChinese, SimplifiedChinese, TencentChinese, Korean
        }
        public LanguageEnum Language;
    }
}