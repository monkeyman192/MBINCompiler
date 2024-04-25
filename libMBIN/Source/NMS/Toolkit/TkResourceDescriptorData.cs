using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4F8F0561C7986C88, NameHash = 0xC24CCFE195015403)]
    public class TkResourceDescriptorData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Id;
        [NMS(Index = 4)]
        /* 0x20 */ public List<NMSTemplate> Children;
        [NMS(Index = 2)]
        /* 0x30 */ public List<NMSString0x80> ReferencePaths;
        [NMS(Index = 3)]
        /* 0x40 */ public float Chance;
        [NMS(Index = 1)]
        /* 0x44 */ public NMSString0x80 Name;
    }
}
