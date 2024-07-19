using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x833165EF7778DB06, NameHash = 0xD1841E4D)]
    public class GcBaseBuildingTable : NMSTemplate
    {
        [NMS(Index = 16)]
        /* 0x000 */ public GcBaseBuildingGroup RelativesTabSetupData;
        [NMS(Index = 14)]
        /* 0x060 */ public GcBaseBuildingProperties Properties;
        [NMS(Index = 3)]
        /* 0x090 */ public TkMaterialResource BuildEffectMaterial;
        [NMS(Index = 1)]
        /* 0x0A8 */ public TkModelResource GhostHeart;
        [NMS(Index = 2)]
        /* 0x0C0 */ public TkModelResource GhostHeartSelected;
        [NMS(Index = 0)]
        /* 0x0D8 */ public TkModelResource LegModel;
        [NMS(Index = 4)]
        /* 0x0F0 */ public TkModelResource RotateScaleGizmo;
        [NMS(Index = 5)]
        /* 0x108 */ public TkModelResource WiringFirefly;
        [NMS(Index = 6)]
        /* 0x120 */ public TkModelResource WiringSnapPoint;
        [NMS(Index = 7)]
        /* 0x138 */ public TkModelResource WiringSnapSelected;
        [NMS(Index = 15)]
        /* 0x150 */ public List<GcBaseBuildingFamily> Families;
        [NMS(Index = 9)]
        /* 0x160 */ public List<GcBaseBuildingGroup> Groups;
        [NMS(Index = 13)]
        /* 0x170 */ public List<GcId256List> MaterialGroups;
        [NMS(Index = 12)]
        /* 0x180 */ public List<GcBaseBuildingMaterial> Materials;
        [NMS(Index = 8)]
        /* 0x190 */ public List<GcBaseBuildingEntry> Objects;
        [NMS(Index = 11)]
        /* 0x1A0 */ public List<GcId256List> PaletteGroups;
        [NMS(Index = 10)]
        /* 0x1B0 */ public List<GcBaseBuildingPalette> Palettes;
    }
}
