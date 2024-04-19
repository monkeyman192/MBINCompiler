using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA99E7ABE96255EDD, NameHash = 0xEB5E59FB895AFF06)]
    public class GcStatsGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public List<GcStatsEntry> StatIds;
        /* 0x20 */ public TkTextureResource Icon;
    }
}
