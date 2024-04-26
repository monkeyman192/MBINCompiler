using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9839317928D40A5, NameHash = 0xB700CDCA231A2974)]
    public class GcLegacyItemTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcLegacyItem> Table;
    }
}
