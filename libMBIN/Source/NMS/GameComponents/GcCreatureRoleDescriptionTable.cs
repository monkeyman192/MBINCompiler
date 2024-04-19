using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF8CB9B0AA2EA3F3C, NameHash = 0xBCFEFAC14ECD961B)]
    public class GcCreatureRoleDescriptionTable : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureRoleDescription> RoleDescription;
        /* 0x10 */ public GcPlanetLife LifeLevel;
        /* 0x14 */ public float MaxScaleVariance;
        /* 0x18 */ public float MinScaleVariance;
        /* 0x1C */ public GcTerrainTileType TileType;
    }
}
