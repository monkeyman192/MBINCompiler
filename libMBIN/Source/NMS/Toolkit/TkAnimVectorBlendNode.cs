using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x18, GUID = 0x1300B3988CAEE69E, NameHash = 0xCEE7FEFDA2096939)]
    public class TkAnimVectorBlendNode : NMSTemplate
    {
		public enum BlendOperationEnum { Blend, Add }
		public BlendOperationEnum BlendOperation;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        public List<TkAnimVectorBlendNodeData> BlendChildren;
    }
}
