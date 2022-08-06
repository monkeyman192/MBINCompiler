using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2C9685FB3FF52145, NameHash = 0x191D46F3F57EB028)]
    public class GcAtlasSendSubmitDiscoveryExact : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public GcAtlasDiscoveryData Data;
        /* 0x58 */ public GcAtlasDiscoveryMetadata Metadata;
    }
}
