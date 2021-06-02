using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x870, GUID = 0x69215BF6BF06CB83, NameHash = 0x17AC2C984675F276)]
    public class GcCreatureSpawnData : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement Resource;
        /* 0x2A8 */ public GcResourceElement FemaleResource;
        /* 0x558 */ public GcResourceElement ExtraResource;
        /* 0x7F8 */ public GcTerrainTileType TileType;
        /* 0x7FC */ public bool SwapPrimaryForSecondaryColour;
        /* 0x7FD */ public bool SwapPrimaryForRandomColour;
        /* 0x800 */ public float MinScale;
        /* 0x804 */ public float MaxScale;
        /* 0x808 */ public NMSString0x10 CreatureID;
        /* 0x818 */ public GcCreatureTypes CreatureType;
        /* 0x81C */ public GcCreatureRoles CreatureRole;
        /* 0x820 */ public NMSString0x20 Filter;
        /* 0x840 */ public int CreatureMinGroupSize;
        /* 0x844 */ public int CreatureMaxGroupSize;
        /* 0x848 */ public float CreatureGroupsPerSquareKm;
        /* 0x84C */ public GcCreatureHemiSphere HemiSphere;
        /* 0x850 */ public float CreatureSpawnDistance;
        /* 0x854 */ public float CreatureDespawnDistance;
        /* 0x858 */ public float CreatureActiveInDayChance;
        /* 0x85C */ public float CreatureActiveInNightChance;
        /* 0x860 */ public GcRarity Rarity;
        /* 0x864 */ public bool Herd;
        /* 0x868 */ public int RoleDataIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x86C */ public byte[] EndPadding;
    }
}
