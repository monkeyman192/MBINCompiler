using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA60B91F466ECCEE4, NameHash = 0x4B1FC18F2123392C)]
    public class GcSeasonalRingArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSeasonalRingData> SeasonalRingData;
    }
}
