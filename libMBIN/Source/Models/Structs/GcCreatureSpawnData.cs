namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x598)]
    public class GcCreatureSpawnData : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement Resource;
        /* 0x2A8 */ public GcResourceElement FemaleResource;

        /* 0x550 */ public GcTerrainTileType PlacementTileType;

        /* 0x554 */ public bool SwapPrimaryForSecondaryColour;
        /* 0x555 */ public bool SwapPrimaryForRandomColour;

        /* 0x558 */ public float PositioningMinScale;
        /* 0x55C */ public float PositioningMaxScale;

        [NMS(Size = 0x10)]
        /* 0x560 */ public string CreatureID;
        /* 0x570 */ public GcCreatureTypes CreatureType;
        /* 0x574 */ public GcCreatureRoles CreatureRole;
        /* 0x578 */ public int CreatureMinGroupSize;
        /* 0x57C */ public int CreatureMaxGroupSize;
        /* 0x580 */ public float CreatureGroupsPerSquareKm;
        /* 0x584 */ public float CreatureSpawnDistance;
        /* 0x588 */ public float CreatureDespawnDistance;
        /* 0x58C */ public float CreatureActiveInDayChance;
        /* 0x590 */ public float CreatureActiveInNightChance;
        /* 0x594 */ public int RoleDataIndex;
    }
}
