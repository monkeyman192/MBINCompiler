using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x32CA52ABC9C20A6D, NameHash = 0xB7495A7C)]
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
