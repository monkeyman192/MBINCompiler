using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x19C25C9B8F6C3B60, NameHash = 0xCA155452FD6149EC)]
    public class GcHUDLayerData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcHUDComponent Data;
        [NMS(Index = 1)]
        /* 0x28 */ public List<NMSTemplate> Children;
    }
}
