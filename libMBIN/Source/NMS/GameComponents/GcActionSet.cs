using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x78, GUID = 0x4A236D358423CE00, NameHash = 0xA14126BE226C6660)]
    public class GcActionSet : NMSTemplate
    {
        public GcActionSetType Type;
        public GcActionUseType Status;
        public NMSString0x20 ExternalId;
        public NMSString0x20 ExternalLoc;
        public NMSString0x20 LocTag;
        public List<GcActionSetAction> Actions;
    }
}
