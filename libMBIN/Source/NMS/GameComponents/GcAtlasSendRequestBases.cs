using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x60, GUID = 0xF8653D82867B12BE, NameHash = 0x8224EED427CDE62A)]
    public class GcAtlasSendRequestBases : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        [NMS(Size = 0x8, Ignore = true)]
        // I think this isn't quite right but I'm not sure what to put instead...
        /* 0x08 */ public byte[] Padding8;
        /* 0x10 */ public GcUniverseAddressData UniverseAddress;
        /* 0x28 */ public GcGameMode Gamemode;
        /* 0x2C */ public int MaxResults;
        /* 0x30 */ public int MaxBytes;
        /* 0x34 */ public int MinVersion;
        /* 0x38 */ public int MaxVersion;
        /* 0x3C */ public NMSString0x20 SpecificUserId;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x5C */ public byte[] EndPadding;
    }
}
