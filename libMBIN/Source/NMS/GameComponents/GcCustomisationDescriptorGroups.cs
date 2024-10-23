using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAFF8B9F2932BFD7B, NameHash = 0xF28D85CB)]
    public class GcCustomisationDescriptorGroups : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcCustomisationDescriptorGroupSet> DescriptorGroupSets;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcCustomisationHeadToRace> HeadRaces;
    }
}
