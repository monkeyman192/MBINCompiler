using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x130, GUID = 0x38832725CE598FFB, NameHash = 0xBCFA2AE11CD16318)]
    public class TkLocalisationEntry : NMSTemplate
    {
        public NMSString0x20 Id;

        public VariableSizeString English;
        public VariableSizeString French;
        public VariableSizeString Italian;
        public VariableSizeString German;
        public VariableSizeString Spanish;
        public VariableSizeString Russian;
        public VariableSizeString Polish;
        public VariableSizeString Dutch;
        public VariableSizeString Portuguese;
        public VariableSizeString LatinAmericanSpanish;
        public VariableSizeString BrazilianPortuguese;
        public VariableSizeString SimplifiedChinese;
        public VariableSizeString TraditionalChinese;
        public VariableSizeString TencentChinese;
        public VariableSizeString Korean;
        public VariableSizeString Japanese;
        public VariableSizeString USEnglish;
    }
}
