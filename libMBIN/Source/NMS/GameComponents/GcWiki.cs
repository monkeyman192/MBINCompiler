using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x53BD69909CA003AB, NameHash = 0x2FA75F60)]
    public class GcWiki : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcWikiCategory> Categories;
    }
}
