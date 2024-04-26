using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7BF6829A0ED8BCD1, NameHash = 0x6E58FF6D49923F40)]
    public class TkResourceDescriptorList : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<TkResourceDescriptorData> Descriptors;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 TypeId;
    }
}
