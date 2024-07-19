using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x617738D45CA39D41, NameHash = 0x95A6BF76)]
    public class GcVibrationDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcVibrationChannelData> Data;
    }
}
