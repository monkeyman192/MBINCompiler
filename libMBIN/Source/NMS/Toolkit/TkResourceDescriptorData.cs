using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9E1E61825555FB4C, NameHash = 0x367EBA03)]
    public class TkResourceDescriptorData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Id;
        [NMS(Index = 4)]
        /* 0x20 */ public List<NMSTemplate> Children;
        [NMS(Index = 2)]
        /* 0x30 */ public List<VariableSizeString> ReferencePaths;
        [NMS(Index = 3)]
        /* 0x40 */ public float Chance;
        [NMS(Index = 1)]
        /* 0x44 */ public NMSString0x80 Name;
    }
}
