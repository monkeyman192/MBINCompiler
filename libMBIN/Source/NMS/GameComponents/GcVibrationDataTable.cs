using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDB778A9862A75902, NameHash = 0x75E1ADCE47B381E6)]
    public class GcVibrationDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcVibrationChannelData> Data;
    }
}
