using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF652C9123B23EEEF, NameHash = 0x2C1B6B0E807F7193)]
    public class TkSceneNodeData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public List<TkSceneNodeAttributeData> Attributes;
        [NMS(Index = 5)]
        /* 0x10 */ public List<TkSceneNodeData> Children;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x10 Type;
        [NMS(Index = 3)]
        /* 0x30 */ public TkTransformData Transform;
        [NMS(Index = 1)]
        /* 0x54 */ public uint NameHash;
        [NMS(Index = 0)]
        /* 0x58 */ public NMSString0x80 Name;
    }
}
