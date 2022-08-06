using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF2B265D034AAE8EB, NameHash = 0x4B1FC18F2123392C)]
    public class GcSeasonalRingArray : NMSTemplate
    {
        public List<GcSeasonalRingData> SeasonalRingData;
    }
}
