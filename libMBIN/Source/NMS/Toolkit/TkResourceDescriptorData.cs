using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4F8F0561C7986C88, NameHash = 0xC24CCFE195015403)]
    public class TkResourceDescriptorData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Id;
        /* 0x20 */ public List<NMSTemplate> Children;
        /* 0x30 */ public List<NMSString0x80> ReferencePaths;
        /* 0x40 */ public float Chance;
        /* 0x44 */ public NMSString0x80 Name;
    }
}
