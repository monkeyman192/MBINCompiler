using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1C00, GUID = 0x3AED05701689E516, NameHash = 0x69B43206529CA591)]
    public class GcBaseBuildingTable : NMSTemplate
    {
        /* 0x0000 */ public TkModelResource LegModel;
        /* 0x0084 */ public TkModelResource GhostHeart;
        /* 0x0108 */ public TkModelResource GhostHeartSelected;
        /* 0x018C */ public TkMaterialResource BuildEffectMaterial;
        /* 0x0210 */ public TkModelResource RotateScaleGizmo;
        /* 0x0294 */ public TkModelResource WiringFirefly;
        /* 0x0318 */ public TkModelResource WiringSnapPoint;
        /* 0x039C */ public TkModelResource WiringSnapUsed;
        /* 0x0420 */ public TkModelResource WiringSnapSelected;

        [NMS(Size = 4, Ignore = true)]
        /* 0x04A4 */ public byte[] Padding4A4;

        /* 0x04A8 */ public List<GcBaseBuildingEntry> Objects;
        /* 0x04B8 */ public List<GcBaseBuildingGroup> Groups;

        [NMS(Size = 8, Ignore = true)]
        /* 0x04C8 */ public byte[] Padding4C8;

        [NMS(Size = 0x10)]
        /* 0x04D0 */ public GcBaseBuildingPalette[] Palettes;
        [NMS(Size = 0x4)]
        /* 0x08D0 */ public GcBaseBuildingMaterial[] Materials;
        /* 0x1BD0 */ public string DefaultInBaseObject;
        [NMS(Size = 0x10)]
        /* 0x1BE0 */ public string DefaultOnTerrainObject;
        [NMS(Size = 0x10)]
        /* 0x1BF0 */ public string DefaultInFreighterObject;
    }
}
