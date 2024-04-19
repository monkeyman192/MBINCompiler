using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA8FC109589446C5, NameHash = 0xEAAFF5007DC2452C)]
    public class GcSettlementPerkData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Description;
        /* 0x20 */ public NMSString0x20A Name;
        /* 0x40 */ public NMSString0x10 ID;
        /* 0x50 */ public List<GcSettlementStatChange> StatChanges;
        /* 0x60 */ public bool IsJob;
        /* 0x61 */ public bool IsNegative;
        /* 0x62 */ public bool IsProc;
        /* 0x63 */ public bool IsStarter;
    }
}
