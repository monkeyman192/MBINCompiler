using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x651EDE260E2776E6, NameHash = 0x58E509FD)]
    public class GcCreatureRoleData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public GcCreatureInfo Info;
        [NMS(Index = 3)]
        /* 0x518 */ public GcCreatureRoleDescription Description;
        [NMS(Index = 9)]
        /* 0x580 */ public NMSString0x20A Filter;
        [NMS(Index = 2)]
        /* 0x5A0 */ public NMSString0x10 CreatureId;
        [NMS(Index = 0)]
        /* 0x5B0 */ public GcSeed Seed;
        [NMS(Index = 6)]
        /* 0x5C0 */ public GcCreatureDiet Diet;
        [NMS(Index = 7)]
        /* 0x5C4 */ public float GroupsPerSquareKm;
        [NMS(Index = 8)]
        /* 0x5C8 */ public GcCreatureHemiSphere HemiSphere;
        [NMS(Index = 5)]
        /* 0x5CC */ public GcTerrainTileType TileType;
        [NMS(Index = 1)]
        /* 0x5D0 */ public GcCreatureTypes Type;
    }
}
