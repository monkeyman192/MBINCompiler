namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF4BFC7159347CAF3, NameHash = 0x1FD33D08A7082C22)]
    public class GcSpaceStationSpawnData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public Vector3f SpawnFacing;
        [NMS(Index = 3)]
        /* 0x10 */ public Vector3f SpawnPosition;
        [NMS(Index = 1)]
        /* 0x20 */ public GcSeed Seed;
        // size: 0x3
        public enum SpawnModeEnum : uint {
            None,
            UseSeed,
            UseAltID,
        }
        [NMS(Index = 0)]
        /* 0x30 */ public SpawnModeEnum SpawnMode;
        [NMS(Index = 2)]
        /* 0x34 */ public NMSString0x100 AltId;
    }
}
