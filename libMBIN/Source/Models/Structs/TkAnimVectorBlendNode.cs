using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x18)]
    public class TkAnimVectorBlendNode : NMSTemplate
    {
        public int BlendOperation;
        public string[] BlendOperationValues()
        {
            return new[] { "Blend", "Add"};
        }
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        public List<TkAnimVectorBlendNodeData> BlendChildren;
    }
}
