using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1DCCBBEBB4547EB4, NameHash = 0x2C1B6B0E807F7193)]
    public class TkSceneNodeData : NMSTemplate
    {
        /* 0x00 */ public List<TkSceneNodeAttributeData> Attributes;
        /* 0x10 */ public List<TkSceneNodeData> Children;
        /* 0x20 */ public NMSString0x10 Type;
        /* 0x30 */ public TkTransformData Transform;
        /* 0x54 */ public uint NameHash;
        /* 0x58 */ public NMSString0x80 Name;
    }
}
