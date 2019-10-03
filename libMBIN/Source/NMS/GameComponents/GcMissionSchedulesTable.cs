using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD99DA1D84588E2FB, NameHash = 0xEAA492CB3579B238)]
    public class GcMissionSchedulesTable : NMSTemplate
    {
        public List<GcMissionSchedulingData> Schedules;
    }
}
