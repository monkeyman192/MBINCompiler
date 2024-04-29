using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5C41BACD920C74FE, NameHash = 0x662BA34BF46DF2DB)]
    public class GcWFCDecorationSet : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcWFCDecorationItem> Items;
    }
}
