using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0xA372A47F9093AA1D, NameHash = 0xA601980170B475C0)]
    public class GcMissionConditionIsScanEventRepaired : NMSTemplate
    {
        public NMSString0x20 Event;
    }
}
