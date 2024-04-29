using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9BB810EB2203BF80, NameHash = 0x5D212FC5B6A065A4)]
    public class TkLanguageFontTableEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public TkLanguages Language;
        [NMS(Index = 3)]
        /* 0x004 */ public NMSString0x80 ConsoleFont;
        [NMS(Index = 4)]
        /* 0x084 */ public NMSString0x80 ConsoleFont2;
        [NMS(Index = 1)]
        /* 0x104 */ public NMSString0x80 GameFont;
        [NMS(Index = 2)]
        /* 0x184 */ public NMSString0x80 GameFont2;
    }
}
