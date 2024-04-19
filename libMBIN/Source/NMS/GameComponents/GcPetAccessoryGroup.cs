using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6C7DF361FDD755CB, NameHash = 0x1ED57D0465F00894)]
    public class GcPetAccessoryGroup : NMSTemplate
    {
        /* 0x00 */ public List<GcPetAccessoryType> DisallowedAccessories;
        /* 0x10 */ public NMSString0x10 Id;
    }
}
