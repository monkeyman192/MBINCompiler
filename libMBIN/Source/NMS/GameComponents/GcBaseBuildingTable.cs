using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74C1CCE2975CDBA, NameHash = 0x69B43206529CA591)]
    public class GcBaseBuildingTable : NMSTemplate
    {
        /* 0x000 */ public GcBaseBuildingGroup RelativesTabSetupData;
        /* 0x0C8 */ public GcBaseBuildingProperties Properties;
        /* 0x0F8 */ public List<GcBaseBuildingFamily> Families;
        /* 0x108 */ public List<GcBaseBuildingGroup> Groups;
        /* 0x118 */ public List<GcId256List> MaterialGroups;
        /* 0x128 */ public List<GcBaseBuildingMaterial> Materials;
        /* 0x138 */ public List<GcBaseBuildingEntry> Objects;
        /* 0x148 */ public List<GcId256List> PaletteGroups;
        /* 0x158 */ public List<GcBaseBuildingPalette> Palettes;
        /* 0x168 */ public TkMaterialResource BuildEffectMaterial;
        /* 0x1EC */ public TkModelResource GhostHeart;
        /* 0x270 */ public TkModelResource GhostHeartSelected;
        /* 0x2F4 */ public TkModelResource LegModel;
        /* 0x378 */ public TkModelResource RotateScaleGizmo;
        /* 0x3FC */ public TkModelResource WiringFirefly;
        /* 0x480 */ public TkModelResource WiringSnapPoint;
        /* 0x504 */ public TkModelResource WiringSnapSelected;
    }
}
