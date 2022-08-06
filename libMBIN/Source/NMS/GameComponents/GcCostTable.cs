using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x276986A3D3352847, NameHash = 0x6E62CCB542C4E505)]
    public class GcCostTable : NMSTemplate
    {
        /* 0x00 */ public List<GcCostTableEntry> SimpleInteractionTable;
        /* 0x10 */ public List<GcCostTableEntry> InteractionTable;
        /* 0x20 */ public List<GcCostTableEntry> ItemCostsTable;
        /* 0x30 */ public List<GcCostTableEntry> AtlasPathCosts;
        /* 0x40 */ public List<GcCostTableEntry> UnusedCostsTable;
    }
}
