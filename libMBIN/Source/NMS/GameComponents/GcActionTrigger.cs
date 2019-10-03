using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0x1DFBCEEAFDE9D7C6, Alignment = 0x8, NameHash = 0x269AA19701CADAB8)]
    public class GcActionTrigger : NMSTemplate
    {
        public NMSTemplate Trigger;
        public List<NMSTemplate> Action;
    }
}
