using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6C2848F5D0E37898, NameHash = 0x57CBFDF164E923E9)]
    public class GcCustomisationDescriptorGroupOptions : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A GroupTitle;
        /* 0x20 */ public List<GcCustomisationDescriptorGroupOption> DescriptorGroupOptions;
        /* 0x30 */ public List<NMSString0x10> PrerequisiteGroup;
        /* 0x40 */ public bool FirstOptionIsEmpty;
    }
}
