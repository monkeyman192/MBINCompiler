using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x20, GUID = 0x328BC8722EB81B1F, NameHash = 0x6E58FF6D49923F40)]
    public class TkResourceDescriptorList : NMSTemplate
    {
        public NMSString0x10 TypeId;
        public List<TkResourceDescriptorData> Descriptors;
    }
}