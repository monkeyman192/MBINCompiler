using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x85EAE598340B4C9E, NameHash = 0x51A3F598097EC1ED)]
    public class GcActionTriggerState : NMSTemplate
    {
        public NMSString0x10 StateID;
        public List<GcActionTrigger> Triggers;
    }
}
