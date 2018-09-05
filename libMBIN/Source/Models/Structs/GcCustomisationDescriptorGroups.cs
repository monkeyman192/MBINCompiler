using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x10)]
    public class GcCustomisationDescriptorGroups : NMSTemplate
    {
        public List<GcCustomisationDescriptorGroup> DescriptorGroups;
    }
}
