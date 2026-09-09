using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2BD89C5E79B3BF68, NameHash = 0xD1841E4D)]
    public class GcBaseBuildingTable : NMSTemplate
    {
        [NMS(Index = 16)]
        /* 0x000 */ public GcBaseBuildingGroup RelativesTabSetupData;
        [NMS(Index = 14)]
        /* 0x060 */ public GcBaseBuildingProperties Properties;
        [NMS(Index = 1)]
        /* 0x090 */ public TkModelResource GhostHeart;
        [NMS(Index = 2)]
        /* 0x0B0 */ public TkModelResource GhostHeartSelected;
        [NMS(Index = 0)]
        /* 0x0D0 */ public TkModelResource LegModel;
        [NMS(Index = 4)]
        /* 0x0F0 */ public TkModelResource RotateScaleGizmo;
        [NMS(Index = 5)]
        /* 0x110 */ public TkModelResource WiringFirefly;
        [NMS(Index = 6)]
        /* 0x130 */ public TkModelResource WiringSnapPoint;
        [NMS(Index = 7)]
        /* 0x150 */ public TkModelResource WiringSnapSelected;
        [NMS(Index = 3)]
        /* 0x170 */ public TkMaterialResource BuildEffectMaterial;
        [NMS(Index = 15)]
        /* 0x188 */ public List<GcBaseBuildingFamily> Families;
        [NMS(Index = 9)]
        /* 0x198 */ public List<GcBaseBuildingGroup> Groups;
        [NMS(Index = 13)]
        /* 0x1A8 */ public List<GcId256List> MaterialGroups;
        [NMS(Index = 12)]
        /* 0x1B8 */ public List<GcBaseBuildingMaterial> Materials;
        [NMS(Index = 8)]
        /* 0x1C8 */ public List<GcBaseBuildingEntry> Objects;
        [NMS(Index = 11)]
        /* 0x1D8 */ public List<GcId256List> PaletteGroups;
        [NMS(Index = 10)]
        /* 0x1E8 */ public List<GcBaseBuildingPalette> Palettes;
    }
}
