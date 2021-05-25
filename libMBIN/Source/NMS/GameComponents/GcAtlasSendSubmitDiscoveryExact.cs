using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xD8, GUID = 0x08C6E3E86B46A306, NameHash = 0x191D46F3F57EB028)]
    public class GcAtlasSendSubmitDiscoveryExact : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        /* 0x10 */ public GcAtlasDiscoveryData Data;
        /* 0x58 */ public GcAtlasDiscoveryMetadata Metadata;
    }
}
