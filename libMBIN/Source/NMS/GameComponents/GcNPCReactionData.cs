using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x31D8EAFAAE2B4184, NameHash = 0xA83B1CD89A122A08)]
    public class GcNPCReactionData : NMSTemplate
    {
        public List<GcNPCReactionEntry> Rections;
    }
}
