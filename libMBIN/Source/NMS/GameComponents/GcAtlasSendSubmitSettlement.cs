using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF801A86FC007E998, NameHash = 0x24040EB4305E158E)]
    public class GcAtlasSendSubmitSettlement : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x000 */ public byte[] Padding0;
        /* 0x008 */ public ulong ClientUserdata;
        /* 0x010 */ public GcGameMode GameMode;
        /* 0x014 */ public GcSettlementState SettlementData;
        /* 0x504 */ public bool DeleteRequest;
        // There are empty bytes at the end?? Something is weird here...
        [NMS(Size = 0x1B, Ignore = true)]
        /* 0x505 */ public byte[] EndPadding;
    }
}
