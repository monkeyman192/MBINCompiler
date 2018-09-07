using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x18)]
    public class TkAnimVectorBlendNode : NMSTemplate
    {
		public enum BlendOperationEnum { Blend, Add }
		public BlendOperationEnum BlendOperation;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        public List<TkAnimVectorBlendNodeData> BlendChildren;
    }
}
