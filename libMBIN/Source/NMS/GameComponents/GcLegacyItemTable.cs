using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF974C2743E5A452C, NameHash = 0xB700CDCA231A2974)]
    public class GcLegacyItemTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcLegacyItem> Table;
    }
}
