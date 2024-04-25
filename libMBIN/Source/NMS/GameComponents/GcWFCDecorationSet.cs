using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD229719484E0E2B7, NameHash = 0x662BA34BF46DF2DB)]
    public class GcWFCDecorationSet : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcWFCDecorationItem> Items;
    }
}
