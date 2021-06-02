using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xC8, GUID = 0xABD3B610D1E296E6, NameHash = 0xC24CCFE195015403)]
    public class TkResourceDescriptorData : NMSTemplate
    {
        public NMSString0x20 Id;
        public NMSString0x80 Name;
        public List<NMSString0x80> ReferencePaths;
        public float Chance;
        public List<NMSTemplate> Children;
    }
}