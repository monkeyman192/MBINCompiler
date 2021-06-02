using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x298, GUID = 0x1512A8A65E002815, NameHash = 0xF676D3AEF2BB991F)]
    public class GcAtlasBase : NMSTemplate
    {
        /* 0x000 */ public NMSString0x200 OpaqueData;
        /* 0x200 */ public GcUniverseAddressData UniverseAddress;
        /* 0x218 */ public NMSString0x80 CustomName;
    }
}
