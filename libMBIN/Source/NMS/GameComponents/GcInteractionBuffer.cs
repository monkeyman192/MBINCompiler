using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xA055E241AA30DB8, NameHash = 0x7355BB5E5AC6EB4A)]
    public class GcInteractionBuffer : NMSTemplate
    {
        public List<GcInteractionData> Interactions;
    }
}
