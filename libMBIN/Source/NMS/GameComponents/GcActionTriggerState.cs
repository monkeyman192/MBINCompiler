using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcActionTriggerState : NMSTemplate
    {
        public NMSString0x10 StateID;
        public List<GcActionTrigger> Triggers;
    }
}
