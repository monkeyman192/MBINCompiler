using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x50)]
    public class GcCostTable : NMSTemplate
    {
        public List<GcCostTableEntry> SimpleInteractionTable;
        public List<GcCostTableEntry> InteractionTable;
        public List<GcCostTableEntry> ItemCostsTable;
        public List<GcCostTableEntry> AtlasPathCosts;
        public List<GcCostTableEntry> UnusedCostsTable;
    }
}
