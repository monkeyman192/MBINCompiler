using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x19F0)]
    public class GcBaseBuildingTable : NMSTemplate
    {
        /* 0x0000 */ public TkModelResource LegModel;
        /* 0x0084 */ public TkModelResource BaseRadiusModel;
        /* 0x0108 */ public TkModelResource SnapPointValid;
        /* 0x018C */ public TkModelResource SnapPointInvalid;
        /* 0x0210 */ public TkModelResource SnapPointFar;

        [NMS(Size = 4, Ignore = true)]
        /* 0x0294 */ public byte[] Padding294;

        /* 0x0298 */ public List<GcBaseBuildingEntry> Objects;
        /* 0x02A8 */ public List<GcBaseBuildingGroup> Groups;

        [NMS(Size = 8, Ignore = true)]
        /* 0x02B8 */ public byte[] Padding2B8;

        [NMS(Size = 0x10)]
        /* 0x02C0 */ public GcBaseBuildingPalette[] Palettes;
        [NMS(Size = 0x4)]
        /* 0x06C0 */ public GcBaseBuildingMaterial[] Materials;
        /* 0x19C0 */ public GcBaseBuildingProperties Properties;
    }
}
