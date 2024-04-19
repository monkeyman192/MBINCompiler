namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB2FF18440DA1DBF7, NameHash = 0x1FD33D08A7082C22)]
    public class GcSpaceStationSpawnData : NMSTemplate
    {
        /* 0x00 */ public Vector3f SpawnFacing;
        /* 0x10 */ public Vector3f SpawnPosition;
        /* 0x20 */ public GcSeed Seed;
        // size: 0x3
        public enum SpawnModeEnum : uint {
            None,
            UseSeed,
            UseAltID,
        }
        /* 0x30 */ public SpawnModeEnum SpawnMode;
        /* 0x34 */ public NMSString0x100 AltId;
    }
}
