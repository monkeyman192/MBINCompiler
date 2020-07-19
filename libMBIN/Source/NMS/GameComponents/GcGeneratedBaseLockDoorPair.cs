using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x6EE01E533F478408, NameHash = 0xD8474E74CF9A3BB)]
    public class GcGeneratedBaseLockDoorPair : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Door;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string Lock;
    }
}
