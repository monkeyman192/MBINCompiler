using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFE319BC8B49DB8C4, NameHash = 0xE3CA41789B108657)]
    public class GcBuildingColourPalette : NMSTemplate
    {
        /* 0x0 */ public GcBuildingClassification Building;
        /* 0x8 */ public List<GcWeightedColourId> Palettes;
    }
}
