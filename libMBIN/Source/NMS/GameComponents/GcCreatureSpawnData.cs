using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x76A6E9E8E6075454, NameHash = 0x17785270)]
    public class GcCreatureSpawnData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public GcResourceElement ExtraResource;
        [NMS(Index = 1)]
        /* 0x048 */ public GcResourceElement FemaleResource;
        [NMS(Index = 0)]
        /* 0x090 */ public GcResourceElement Resource;
        [NMS(Index = 11)]
        /* 0x0D8 */ public NMSString0x20A Filter;
        [NMS(Index = 8)]
        /* 0x0F8 */ public NMSString0x10 CreatureID;
        [NMS(Index = 18)]
        /* 0x108 */ public float CreatureActiveInDayChance;
        [NMS(Index = 19)]
        /* 0x10C */ public float CreatureActiveInNightChance;
        [NMS(Index = 17)]
        /* 0x110 */ public float CreatureDespawnDistance;
        [NMS(Index = 14)]
        /* 0x114 */ public float CreatureGroupsPerSquareKm;
        [NMS(Index = 13)]
        /* 0x118 */ public int CreatureMaxGroupSize;
        [NMS(Index = 12)]
        /* 0x11C */ public int CreatureMinGroupSize;
        [NMS(Index = 10)]
        /* 0x120 */ public GcCreatureRoles CreatureRole;
        [NMS(Index = 16)]
        /* 0x124 */ public float CreatureSpawnDistance;
        [NMS(Index = 9)]
        /* 0x128 */ public GcCreatureTypes CreatureType;
        [NMS(Index = 15)]
        /* 0x12C */ public GcCreatureHemiSphere HemiSphere;
        [NMS(Index = 7)]
        /* 0x130 */ public float MaxScale;
        [NMS(Index = 6)]
        /* 0x134 */ public float MinScale;
        [NMS(Index = 20)]
        /* 0x138 */ public GcRarity Rarity;
        [NMS(Index = 23)]
        /* 0x13C */ public int RoleDataIndex;
        [NMS(Index = 3)]
        /* 0x140 */ public GcTerrainTileType TileType;
        [NMS(Index = 21)]
        /* 0x144 */ public bool AllowFur;
        [NMS(Index = 22)]
        /* 0x145 */ public bool Herd;
        [NMS(Index = 5)]
        /* 0x146 */ public bool SwapPrimaryForRandomColour;
        [NMS(Index = 4)]
        /* 0x147 */ public bool SwapPrimaryForSecondaryColour;
    }
}
