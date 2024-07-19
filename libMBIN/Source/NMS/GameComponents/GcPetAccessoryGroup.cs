using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x76BC52099700020A, NameHash = 0x8633AB70)]
    public class GcPetAccessoryGroup : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcPetAccessoryType> DisallowedAccessories;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Id;
    }
}
