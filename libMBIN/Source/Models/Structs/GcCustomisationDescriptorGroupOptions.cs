using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x30)]
    public class GcCustomisationDescriptorGroupOptions : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string GroupTitle;
        public List<GcCustomisationDescriptorGroupOption> DescriptorGroupOptions;
    }
}
