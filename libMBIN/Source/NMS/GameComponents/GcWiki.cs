using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA4EF7703759EF9C7, NameHash = 0x1037140D8873D8ED)]
    public class GcWiki : NMSTemplate
    {
        public List<GcWikiCategory> Categories;
    }
}
