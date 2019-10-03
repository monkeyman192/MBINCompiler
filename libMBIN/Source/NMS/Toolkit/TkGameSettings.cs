using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x28, GUID = 0x2562477FC204D168, NameHash = 0x18F53DCA811C8E56)]
    public class TkGameSettings : NMSTemplate
    {
		public enum LanguageSettingEnum { Default, english, french, italian, german, spanish, russian, polish, dutch, portuguese, brazilianportuguese, japanese, traditionalchinese, simplifiedchinese, korean }
		public LanguageSettingEnum LanguageSetting;

        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        public List<GcInputActionMapping> Keymapping;
        public List<GcInputActionMapping2> KeyMapping2;
    }
}
