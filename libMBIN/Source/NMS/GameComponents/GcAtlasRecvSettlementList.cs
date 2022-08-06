using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x066C59EC3D078FEF, NameHash = 0xCE8A17798827ECBE)]
    public class GcAtlasRecvSettlementList : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public int NumberOfSettlements;
        [NMS(Size = 0x64)]
        /* 0x20 */ public GcSettlementState[] Settlements;
    }
}
