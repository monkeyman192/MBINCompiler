using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9BFB3B6D5FFE320A, NameHash = 0xDF80EC28C687305E)]
    public class GcMissionConditionIsScanEventActive : NMSTemplate
    {
        public NMSString0x20A Event;
        public bool MustMatchThisMissionSeed;
    }
}
