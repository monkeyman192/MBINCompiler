using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x204, GUID = 0x31EF165D0298C2F1, NameHash = 0x5D212FC5B6A065A4)]
    public class TkLanguageFontTableEntry : NMSTemplate
    {
        public TkLanguages Language;
        public NMSString0x80 GameFont;
        public NMSString0x80 GameFont2;
        public NMSString0x80 ConsoleFont;
        public NMSString0x80 ConsoleFont2;
    }
}
