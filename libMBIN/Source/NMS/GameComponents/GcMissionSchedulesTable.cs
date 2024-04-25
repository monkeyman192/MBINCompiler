using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE010D63972E1D343, NameHash = 0xEAA492CB3579B238)]
    public class GcMissionSchedulesTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcMissionSchedulingData> Schedules;
    }
}
