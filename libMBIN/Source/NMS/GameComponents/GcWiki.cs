using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x62DC3E9F08886C2C, NameHash = 0x1037140D8873D8ED)]
    public class GcWiki : NMSTemplate
    {
        /* 0x0 */ public List<GcWikiCategory> Categories;
    }
}
