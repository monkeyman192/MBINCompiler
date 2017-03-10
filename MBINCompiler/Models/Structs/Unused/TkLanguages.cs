namespace MBINCompiler.Models.Structs
{
    public class TkLanguages : NMSTemplate 
    {
		/* 0x000 */ public int Language;
		public string[] LanguageValues()
		{
			return new[] { "Default", "English", "USEnglish", "French", "Italian", "German", "Spanish", "Russian", "Polish", "Dutch" "Portuguese", "LatinAmericanSpanish", "BrazilianPortuguese", "Japanese", "TraditionalChinese", "SimplifiedChinese", "Korean"};
		}
    }
}
