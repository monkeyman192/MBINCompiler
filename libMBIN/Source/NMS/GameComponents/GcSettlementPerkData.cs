using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3610F4A01FDC68BF, NameHash = 0xEAAFF5007DC2452C)]
    public class GcSettlementPerkData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public NMSString0x20A Name;
        /* 0x30 */ public NMSString0x20A Description;
        /* 0x50 */ public bool IsNegative;
        /* 0x51 */ public bool IsStarter;
        /* 0x52 */ public bool IsProc;
        /* 0x53 */ public bool IsJob;
        /* 0x58 */ public List<GcSettlementStatChange> StatChanges;
    }
}
