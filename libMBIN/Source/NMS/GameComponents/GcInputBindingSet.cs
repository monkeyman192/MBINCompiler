using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x78BF62171384E4AF, NameHash = 0x52AAFE72AAC465AE)]
    public class GcInputBindingSet : NMSTemplate
    {
        public GcActionSetType Type;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        public List<GcInputBinding> InputBindings;
    }
}
