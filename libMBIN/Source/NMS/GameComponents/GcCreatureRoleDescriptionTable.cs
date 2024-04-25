using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF8CB9B0AA2EA3F3C, NameHash = 0xBCFEFAC14ECD961B)]
    public class GcCreatureRoleDescriptionTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcCreatureRoleDescription> RoleDescription;
        [NMS(Index = 4)]
        /* 0x10 */ public GcPlanetLife LifeLevel;
        [NMS(Index = 2)]
        /* 0x14 */ public float MaxScaleVariance;
        [NMS(Index = 1)]
        /* 0x18 */ public float MinScaleVariance;
        [NMS(Index = 3)]
        /* 0x1C */ public GcTerrainTileType TileType;
    }
}
