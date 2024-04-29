using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8F7B6E1ACBE6E03A, NameHash = 0xCEE7FEFDA2096939)]
    public class TkAnimVectorBlendNode : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<TkAnimVectorBlendNodeData> BlendChildren;
        // size: 0x2
        public enum BlendOperationEnum : uint {
            Blend,
            Add,
        }
        [NMS(Index = 0)]
        /* 0x10 */ public BlendOperationEnum BlendOperation;
    }
}
