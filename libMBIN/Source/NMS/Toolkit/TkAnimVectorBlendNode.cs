using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD0B848F7D4B53523, NameHash = 0xCEE7FEFDA2096939)]
    public class TkAnimVectorBlendNode : NMSTemplate
    {
        /* 0x00 */ public List<TkAnimVectorBlendNodeData> BlendChildren;
        // size: 0x2
        public enum BlendOperationEnum : uint {
            Blend,
            Add,
        }
        /* 0x10 */ public BlendOperationEnum BlendOperation;
    }
}
