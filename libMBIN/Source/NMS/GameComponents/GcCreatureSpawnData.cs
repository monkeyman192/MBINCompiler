using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x473C143475F5977F, NameHash = 0x17AC2C984675F276)]
    public class GcCreatureSpawnData : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement ExtraResource;
        /* 0x2A8 */ public GcResourceElement FemaleResource;
        /* 0x550 */ public GcResourceElement Resource;
        /* 0x7F8 */ public NMSString0x20A Filter;
        /* 0x818 */ public NMSString0x10 CreatureID;
        /* 0x828 */ public float CreatureActiveInDayChance;
        /* 0x82C */ public float CreatureActiveInNightChance;
        /* 0x830 */ public float CreatureDespawnDistance;
        /* 0x834 */ public float CreatureGroupsPerSquareKm;
        /* 0x838 */ public int CreatureMaxGroupSize;
        /* 0x83C */ public int CreatureMinGroupSize;
        /* 0x840 */ public GcCreatureRoles CreatureRole;
        /* 0x844 */ public float CreatureSpawnDistance;
        /* 0x848 */ public GcCreatureTypes CreatureType;
        /* 0x84C */ public GcCreatureHemiSphere HemiSphere;
        /* 0x850 */ public float MaxScale;
        /* 0x854 */ public float MinScale;
        /* 0x858 */ public GcRarity Rarity;
        /* 0x85C */ public int RoleDataIndex;
        /* 0x860 */ public GcTerrainTileType TileType;
        /* 0x864 */ public bool AllowFur;
        /* 0x865 */ public bool Herd;
        /* 0x866 */ public bool SwapPrimaryForRandomColour;
        /* 0x867 */ public bool SwapPrimaryForSecondaryColour;
    }
}
