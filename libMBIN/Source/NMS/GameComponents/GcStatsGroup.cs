using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x59AF3770D97F0019, NameHash = 0xEB5E59FB895AFF06)]
    public class GcStatsGroup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 2)]
        /* 0x10 */ public List<GcStatsEntry> StatIds;
        [NMS(Index = 1)]
        /* 0x20 */ public TkTextureResource Icon;
    }
}
