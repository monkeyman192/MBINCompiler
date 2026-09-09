using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x80D416FA0A73CFD4, NameHash = 0xACE64935)]
    public class GcSpacePoiEncounterFrigateFlybyData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector3f SpawnOffset;
        [NMS(Index = 0)]
        /* 0x10 */ public GcFrigateFlybyType FlybyType;
        [NMS(Index = 3)]
        /* 0x14 */ public float RangeOverride;
        [NMS(Index = 1)]
        /* 0x18 */ public GcSpacePoiEncounterSpawnLocation SpawnLocation;
    }
}
