using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5B1A59246EC1D467, NameHash = 0x39D3AB42)]
    public class GcCustomisationDescriptorGroupFallbackData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 DescriptorGroupID;
        [NMS(Index = 1)]
        /* 0x10 */ public List<NMSString0x10> FallbackPriorityList;
    }
}
