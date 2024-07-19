using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE4ECCECC4F792113, NameHash = 0x961C864D)]
    public class GcFontTable : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcFontTableEntry> Fonts;
        [NMS(Index = 0)]
        /* 0x10 */ public TkLanguages Language;
    }
}
