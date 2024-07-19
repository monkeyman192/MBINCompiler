using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6A9DE02E8902AAC3, NameHash = 0x3DB87E47)]
    public class TkSceneNodeData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public List<TkSceneNodeAttributeData> Attributes;
        [NMS(Index = 6)]
        /* 0x10 */ public List<TkSceneNodeData> Children;
        [NMS(Index = 0)]
        /* 0x20 */ public VariableSizeString Name;
        [NMS(Index = 2)]
        /* 0x30 */ public NMSString0x10 Type;
        [NMS(Index = 3)]
        /* 0x40 */ public TkTransformData Transform;
        [NMS(Index = 1)]
        /* 0x64 */ public uint NameHash;
        [NMS(Index = 4)]
        /* 0x68 */ public sbyte PlatformExclusion;
    }
}
