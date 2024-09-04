using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB80660BF83BFF7A2, NameHash = 0x2FA75F60)]
    public class GcWiki : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcWikiCategory> Categories;
    }
}
