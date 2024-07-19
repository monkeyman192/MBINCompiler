using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x44D568A78FBDBB54, NameHash = 0x2A80495A)]
    public class GcPulseEncounterSpawnObject : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkModelResource Object;
        [NMS(Index = 6)]
        /* 0x18 */ public NMSString0x10 TriggerActionOnSpawn;
        [NMS(Index = 2)]
        /* 0x28 */ public float Pitch;
        [NMS(Index = 4)]
        /* 0x2C */ public float Roll;
        [NMS(Index = 1)]
        /* 0x30 */ public float SpawnScale;
        [NMS(Index = 5)]
        /* 0x34 */ public float UpOffset;
        [NMS(Index = 3)]
        /* 0x38 */ public float Yaw;
    }
}
