using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24CFC25EF26228C8, NameHash = 0x226D51E1)]
    public class GcSpacePoiEncounterMinersData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f SpawnOffset;
        [NMS(Index = 2)]
        /* 0x10 */ public Vector2f Count;
        [NMS(Index = 0)]
        /* 0x18 */ public GcSpacePoiEncounterSpawnLocation SpawnLocation;
    }
}
