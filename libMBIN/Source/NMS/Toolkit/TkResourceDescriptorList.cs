using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE8E8BD4A8C5530F7, NameHash = 0x6E58FF6D49923F40)]
    public class TkResourceDescriptorList : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<TkResourceDescriptorData> Descriptors;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 TypeId;
    }
}
