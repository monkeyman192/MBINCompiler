using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCE66A2E24432399E, NameHash = 0x6E62CCB542C4E505)]
    public class GcCostTable : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<GcCostTableEntry> AtlasPathCosts;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcCostTableEntry> InteractionTable;
        [NMS(Index = 2)]
        /* 0x20 */ public List<GcCostTableEntry> ItemCostsTable;
        [NMS(Index = 0)]
        /* 0x30 */ public List<GcCostTableEntry> SimpleInteractionTable;
        [NMS(Index = 4)]
        /* 0x40 */ public List<GcCostTableEntry> UnusedCostsTable;
    }
}
