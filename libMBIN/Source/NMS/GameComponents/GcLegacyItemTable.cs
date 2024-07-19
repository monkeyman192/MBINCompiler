using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5ACFFC096208B875, NameHash = 0xB58F6BA8)]
    public class GcLegacyItemTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcLegacyItem> Table;
    }
}
