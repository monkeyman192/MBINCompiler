using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E0206B2601F3050, NameHash = 0x266F5269ED2C5661)]
    public class GcStatIconTable : NMSTemplate
    {
        [NMS(Size = 0xBC, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x0 */ public NMSString0x80[] StatIcons;
    }
}
