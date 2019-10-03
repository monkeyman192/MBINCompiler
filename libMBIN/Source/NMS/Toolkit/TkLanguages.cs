using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x86B61CEEE4451AD, NameHash = 0xEA37791FF01A5AF4)]
    public class TkLanguages : NMSTemplate
    {
		public enum LanguageEnum { Default, English, USEnglish, French, Italian, German, Spanish, Russian, Polish, Dutch, Portuguese, LatinAmericanSpanish, BrazilianPortuguese, Japanese, TraditionalChinese, SimplifiedChinese, TencentChinese, Korean }
		public LanguageEnum Language;
    }
}
