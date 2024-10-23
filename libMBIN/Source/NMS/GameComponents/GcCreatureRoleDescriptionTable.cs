using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA65EA440EF40CE76, NameHash = 0xFEAF8B28)]
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
