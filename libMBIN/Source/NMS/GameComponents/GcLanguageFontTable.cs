using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC138CCEBCECE7951, NameHash = 0xE3F7014D)]
    public class GcLanguageFontTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFontTable> Table;
    }
}
