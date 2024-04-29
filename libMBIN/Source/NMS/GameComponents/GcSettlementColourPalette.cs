using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D51F986FD0BCB82, NameHash = 0x4D5124F6D6062BBF)]
    public class GcSettlementColourPalette : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public List<GcBuildingColourPalette> BuildingPalettes;
        [NMS(Index = 3)]
        /* 0x10 */ public List<GcWeightedColourId> DefaultPalettes;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Name;
        [NMS(Index = 2)]
        /* 0x30 */ public GcBaseBuildingPartStyle LimitToStyle;
        [NMS(Index = 1)]
        /* 0x34 */ public float RelativeProbability;
    }
}
