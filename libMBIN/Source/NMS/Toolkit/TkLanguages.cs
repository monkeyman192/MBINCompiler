using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkLanguages : NMSTemplate
    {
        public int Language;
        public string[] LanguageValues()
        {
            return new[] { "Default", "English", "USEnglish", "French", "Italian", "German", "Spanish", "Russian", "Polish", "Dutch", "Portuguese", "LatinAmericanSpanish", "BrazilianPortuguese", "Japanese", "TraditionalChinese", "SimplifiedChinese", "Korean" };
        }
    }
}
