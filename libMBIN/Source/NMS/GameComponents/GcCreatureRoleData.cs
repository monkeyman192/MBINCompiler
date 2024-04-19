using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC31CD7BE6255CB, NameHash = 0x3330409D2B3F48C1)]
    public class GcCreatureRoleData : NMSTemplate
    {
        /* 0x000 */ public GcCreatureInfo Info;
        /* 0x518 */ public GcCreatureRoleDescription Description;
        /* 0x580 */ public NMSString0x20A Filter;
        /* 0x5A0 */ public NMSString0x10 CreatureId;
        /* 0x5B0 */ public GcSeed Seed;
        /* 0x5C0 */ public GcCreatureDiet Diet;
        /* 0x5C4 */ public float GroupsPerSquareKm;
        /* 0x5C8 */ public GcCreatureHemiSphere HemiSphere;
        /* 0x5CC */ public GcTerrainTileType TileType;
        /* 0x5D0 */ public GcCreatureTypes Type;
    }
}
