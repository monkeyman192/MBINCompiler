using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24FE16B10F8C4DDD, NameHash = 0x1DC53C6BE7A69854)]
    public class GcCustomisationGroups : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCustomisationGroup> CustomisationGroups;
    }
}
