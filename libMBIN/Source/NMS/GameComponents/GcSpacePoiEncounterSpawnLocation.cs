namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE369F8F7D07A174A, NameHash = 0xDEF63AB8)]
    public class GcSpacePoiEncounterSpawnLocation : NMSTemplate
    {
        // size: 0x2
        public enum SpawnLocationEnum : uint {
            SpawnAtSpacePoi,
            SpawnRelativeToPlayer,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SpawnLocationEnum SpawnLocation;
    }
}
