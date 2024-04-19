using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x90022DBCF064D8B9, NameHash = 0xE3CA41789B108657)]
    public class GcBuildingColourPalette : NMSTemplate
    {
        /* 0x00 */ public List<GcWeightedColourId> Palettes;
        /* 0x10 */ public GcBuildingClassification Building;
    }
}
