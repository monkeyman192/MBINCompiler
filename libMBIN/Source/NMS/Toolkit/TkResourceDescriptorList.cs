using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB48BD9D8116C0902, NameHash = 0xF4A9BB29)]
    public class TkResourceDescriptorList : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<TkResourceDescriptorData> Descriptors;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 TypeId;
    }
}
