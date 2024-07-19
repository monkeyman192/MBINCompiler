using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEA742B8F5C400AE0, NameHash = 0xE281E250)]
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
