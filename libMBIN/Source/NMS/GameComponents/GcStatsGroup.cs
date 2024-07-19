using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x777813F43DCACD80, NameHash = 0x40C76ADF)]
    public class GcStatsGroup : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkTextureResource Icon;
        [NMS(Index = 0)]
        /* 0x18 */ public NMSString0x10 Id;
        [NMS(Index = 2)]
        /* 0x28 */ public List<GcStatsEntry> StatIds;
    }
}
