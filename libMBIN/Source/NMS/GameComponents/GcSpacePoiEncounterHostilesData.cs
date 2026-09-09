using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x755237522EA3DBC6, NameHash = 0xB45BADAC)]
    public class GcSpacePoiEncounterHostilesData : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public Vector3f SpawnOffset;
        [NMS(Index = 0)]
        /* 0x10 */ public GcResourceElement CustomShipResource;
        [NMS(Index = 2)]
        /* 0x58 */ public NMSString0x10 AttackDefinition;
        [NMS(Index = 4)]
        /* 0x68 */ public float AggroDistance;
        [NMS(Index = 3)]
        /* 0x6C */ public float HostileSpawnSpacing;
        [NMS(Index = 5)]
        /* 0x70 */ public float IdleRadius;
        [NMS(Index = 1)]
        /* 0x74 */ public int NumberOfShips;
        [NMS(Index = 6)]
        /* 0x78 */ public GcSpacePoiEncounterSpawnLocation SpawnLocation;
    }
}
