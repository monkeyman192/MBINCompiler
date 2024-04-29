using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2F7D1EA26B71BA5A, NameHash = 0x17AC2C984675F276)]
    public class GcCreatureSpawnData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public GcResourceElement ExtraResource;
        [NMS(Index = 1)]
        /* 0x2A8 */ public GcResourceElement FemaleResource;
        [NMS(Index = 0)]
        /* 0x550 */ public GcResourceElement Resource;
        [NMS(Index = 11)]
        /* 0x7F8 */ public NMSString0x20A Filter;
        [NMS(Index = 8)]
        /* 0x818 */ public NMSString0x10 CreatureID;
        [NMS(Index = 18)]
        /* 0x828 */ public float CreatureActiveInDayChance;
        [NMS(Index = 19)]
        /* 0x82C */ public float CreatureActiveInNightChance;
        [NMS(Index = 17)]
        /* 0x830 */ public float CreatureDespawnDistance;
        [NMS(Index = 14)]
        /* 0x834 */ public float CreatureGroupsPerSquareKm;
        [NMS(Index = 13)]
        /* 0x838 */ public int CreatureMaxGroupSize;
        [NMS(Index = 12)]
        /* 0x83C */ public int CreatureMinGroupSize;
        [NMS(Index = 10)]
        /* 0x840 */ public GcCreatureRoles CreatureRole;
        [NMS(Index = 16)]
        /* 0x844 */ public float CreatureSpawnDistance;
        [NMS(Index = 9)]
        /* 0x848 */ public GcCreatureTypes CreatureType;
        [NMS(Index = 15)]
        /* 0x84C */ public GcCreatureHemiSphere HemiSphere;
        [NMS(Index = 7)]
        /* 0x850 */ public float MaxScale;
        [NMS(Index = 6)]
        /* 0x854 */ public float MinScale;
        [NMS(Index = 20)]
        /* 0x858 */ public GcRarity Rarity;
        [NMS(Index = 23)]
        /* 0x85C */ public int RoleDataIndex;
        [NMS(Index = 3)]
        /* 0x860 */ public GcTerrainTileType TileType;
        [NMS(Index = 21)]
        /* 0x864 */ public bool AllowFur;
        [NMS(Index = 22)]
        /* 0x865 */ public bool Herd;
        [NMS(Index = 5)]
        /* 0x866 */ public bool SwapPrimaryForRandomColour;
        [NMS(Index = 4)]
        /* 0x867 */ public bool SwapPrimaryForSecondaryColour;
    }
}
