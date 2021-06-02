using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0xD74C5214F802F720, NameHash = 0x1ED57D0465F00894)]
    public class GcPetAccessoryGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public List<GcPetAccessoryType> DisallowedAccessories;
    }
}
