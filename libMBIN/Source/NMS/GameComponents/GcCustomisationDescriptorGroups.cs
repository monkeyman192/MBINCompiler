using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x83E448D62945E146, NameHash = 0xF28D85CB)]
    public class GcCustomisationDescriptorGroups : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCustomisationDescriptorGroupSet> DescriptorGroupSets;
    }
}
