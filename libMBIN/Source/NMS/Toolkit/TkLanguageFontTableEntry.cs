using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x204, GUID = 0x31EF165D0298C2F1, NameHash = 0x5D212FC5B6A065A4)]
    public class TkLanguageFontTableEntry : NMSTemplate
    {
        public TkLanguages Language;
        [NMS(Size = 0x80)]
        public string GameFont;
        [NMS(Size = 0x80)]
        public string GameFont2;
        [NMS(Size = 0x80)]
        public string ConsoleFont;
        [NMS(Size = 0x80)]
        public string ConsoleFont2;
    }
}
