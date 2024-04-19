using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCE66A2E24432399E, NameHash = 0x6E62CCB542C4E505)]
    public class GcCostTable : NMSTemplate
    {
        /* 0x00 */ public List<GcCostTableEntry> AtlasPathCosts;
        /* 0x10 */ public List<GcCostTableEntry> InteractionTable;
        /* 0x20 */ public List<GcCostTableEntry> ItemCostsTable;
        /* 0x30 */ public List<GcCostTableEntry> SimpleInteractionTable;
        /* 0x40 */ public List<GcCostTableEntry> UnusedCostsTable;
    }
}
