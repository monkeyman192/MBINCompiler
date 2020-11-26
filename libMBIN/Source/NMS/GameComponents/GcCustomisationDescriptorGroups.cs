using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x37C54BC373994B80, NameHash = 0xB84E1949AA2825A6)]
    public class GcCustomisationDescriptorGroups : NMSTemplate
    {
        public List<GcCustomisationDescriptorGroup> DescriptorGroups;
    }
}
