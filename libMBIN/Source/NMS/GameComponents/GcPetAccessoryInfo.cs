using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0x8CB7531A66F4D7A5, NameHash = 0x882F732A32DF5872)]
    public class GcPetAccessoryInfo : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 Descriptor;
    }
}
