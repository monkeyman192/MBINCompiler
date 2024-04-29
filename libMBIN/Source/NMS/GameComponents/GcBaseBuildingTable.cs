using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x690C654E1A4DEF88, NameHash = 0x69B43206529CA591)]
    public class GcBaseBuildingTable : NMSTemplate
    {
        [NMS(Index = 16)]
        /* 0x000 */ public GcBaseBuildingGroup RelativesTabSetupData;
        [NMS(Index = 14)]
        /* 0x0C8 */ public GcBaseBuildingProperties Properties;
        [NMS(Index = 15)]
        /* 0x0F8 */ public List<GcBaseBuildingFamily> Families;
        [NMS(Index = 9)]
        /* 0x108 */ public List<GcBaseBuildingGroup> Groups;
        [NMS(Index = 13)]
        /* 0x118 */ public List<GcId256List> MaterialGroups;
        [NMS(Index = 12)]
        /* 0x128 */ public List<GcBaseBuildingMaterial> Materials;
        [NMS(Index = 8)]
        /* 0x138 */ public List<GcBaseBuildingEntry> Objects;
        [NMS(Index = 11)]
        /* 0x148 */ public List<GcId256List> PaletteGroups;
        [NMS(Index = 10)]
        /* 0x158 */ public List<GcBaseBuildingPalette> Palettes;
        [NMS(Index = 3)]
        /* 0x168 */ public TkMaterialResource BuildEffectMaterial;
        [NMS(Index = 1)]
        /* 0x1EC */ public TkModelResource GhostHeart;
        [NMS(Index = 2)]
        /* 0x270 */ public TkModelResource GhostHeartSelected;
        [NMS(Index = 0)]
        /* 0x2F4 */ public TkModelResource LegModel;
        [NMS(Index = 4)]
        /* 0x378 */ public TkModelResource RotateScaleGizmo;
        [NMS(Index = 5)]
        /* 0x3FC */ public TkModelResource WiringFirefly;
        [NMS(Index = 6)]
        /* 0x480 */ public TkModelResource WiringSnapPoint;
        [NMS(Index = 7)]
        /* 0x504 */ public TkModelResource WiringSnapSelected;
    }
}
