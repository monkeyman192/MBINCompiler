using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x149B0FC13115F86D, NameHash = 0xEAA492CB3579B238)]
    public class GcMissionSchedulesTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcMissionSchedulingData> Schedules;
    }
}
