using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x860, GUID = 0xA2A7D9766212FC6B, NameHash = 0x17AC2C984675F276)]
    public class GcCreatureSpawnData : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement Resource;
        /* 0x2A8 */ public GcResourceElement FemaleResource;
        /* 0x558 */ public GcResourceElement ExtraResource;

        /* 0x7F8 */ public GcTerrainTileType PlacementTileType;

        /* 0x7FC */ public bool SwapPrimaryForSecondaryColour;
        /* 0x7FD */ public bool SwapPrimaryForRandomColour;

        /* 0x800 */ public float PositioningMinScale;
        /* 0x804 */ public float PositioningMaxScale;

        [NMS(Size = 0x10)]
        /* 0x808 */ public string CreatureID;
        /* 0x818 */ public GcCreatureTypes CreatureType;
        /* 0x81C */ public GcCreatureRoles CreatureRole;
        [NMS(Size = 0x20)]
        /* 0x820 */ public string Filter;
        /* 0x840 */ public int CreatureMinGroupSize;
        /* 0x844 */ public int CreatureMaxGroupSize;
        /* 0x848 */ public float CreatureGroupsPerSquareKm;
        /* 0x84C */ public float CreatureSpawnDistance;
        /* 0x850 */ public float CreatureDespawnDistance;
        /* 0x854 */ public float CreatureActiveInDayChance;
        /* 0x858 */ public float CreatureActiveInNightChance;
        /* 0x85C */ public int RoleDataIndex;
    }
}
