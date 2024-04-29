using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x609C22C34EC68C14, NameHash = 0x1037140D8873D8ED)]
    public class GcWiki : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcWikiCategory> Categories;
    }
}
