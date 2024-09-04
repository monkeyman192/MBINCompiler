using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD40DE03A3077D31B, NameHash = 0x112D6026)]
    public class GcRewardMultiSpecificItems : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcMultiSpecificItemEntry> Items;
        [NMS(Index = 0)]
        /* 0x10 */ public bool Silent;
    }
}
