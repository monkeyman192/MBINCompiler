using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkResourceDescriptorList : NMSTemplate
    {
        public NMSString0x10 TypeId;
        public List<TkResourceDescriptorData> Descriptors;
    }
}
