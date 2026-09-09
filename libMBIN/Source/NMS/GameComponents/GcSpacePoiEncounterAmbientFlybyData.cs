using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x360FEF8E19B45D4E, NameHash = 0xEA3543CE)]
    public class GcSpacePoiEncounterAmbientFlybyData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f SpawnOffset;
        [NMS(Index = 2)]
        /* 0x10 */ public Vector2f Count;
        [NMS(Index = 0)]
        /* 0x18 */ public GcSpacePoiEncounterSpawnLocation SpawnLocation;
    }
}
