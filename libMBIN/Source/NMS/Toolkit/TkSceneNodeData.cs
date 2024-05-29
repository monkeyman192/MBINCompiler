using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4A36A127E1C3FE8E, NameHash = 0x2C1B6B0E807F7193)]
    public class TkSceneNodeData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public List<TkSceneNodeAttributeData> Attributes;
        [NMS(Index = 5)]
        /* 0x10 */ public List<TkSceneNodeData> Children;
        [NMS(Index = 0)]
        /* 0x20 */ public VariableSizeString Name;
        [NMS(Index = 2)]
        /* 0x30 */ public NMSString0x10 Type;
        [NMS(Index = 3)]
        /* 0x40 */ public TkTransformData Transform;
        [NMS(Index = 1)]
        /* 0x64 */ public uint NameHash;
    }
}
