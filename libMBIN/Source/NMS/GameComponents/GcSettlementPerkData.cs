using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAFD3429956FB7780, NameHash = 0xEAAFF5007DC2452C)]
    public class GcSettlementPerkData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A Description;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A Name;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 ID;
        [NMS(Index = 7)]
        /* 0x50 */ public List<GcSettlementStatChange> StatChanges;
        [NMS(Index = 6)]
        /* 0x60 */ public bool IsJob;
        [NMS(Index = 3)]
        /* 0x61 */ public bool IsNegative;
        [NMS(Index = 5)]
        /* 0x62 */ public bool IsProc;
        [NMS(Index = 4)]
        /* 0x63 */ public bool IsStarter;
    }
}
