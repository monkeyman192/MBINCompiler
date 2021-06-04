using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0xAC7D4BC44729D2D2, NameHash = 0xEAA492CB3579B238)]
    public class GcMissionSchedulesTable : NMSTemplate
    {
        public List<GcMissionSchedulingData> Schedules;
    }
}