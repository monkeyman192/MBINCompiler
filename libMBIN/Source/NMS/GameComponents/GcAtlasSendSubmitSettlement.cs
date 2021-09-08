using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x510, GUID = 0xF47C73F2AD3D3BB5, NameHash = 0x24040EB4305E158E)]
    public class GcAtlasSendSubmitSettlement : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x000 */ public byte[] Padding0;
        /* 0x008 */ public ulong ClientUserdata;
        /* 0x010 */ public GcGameMode GameMode;
        /* 0x014 */ public GcSettlementState SettlementData;
        /* 0x4F4 */ public bool DeleteRequest;
        // There are empty bytes at the end?? Something is weird here...
        [NMS(Size = 0x1B, Ignore = true)]
        /* 0x4F5 */ public byte[] EndPadding;
    }
}
