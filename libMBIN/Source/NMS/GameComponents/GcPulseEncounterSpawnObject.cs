using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2985D956845B00A3, NameHash = 0x82C7C611E7625A21)]
    public class GcPulseEncounterSpawnObject : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public NMSString0x10 TriggerActionOnSpawn;
        [NMS(Index = 0)]
        /* 0x10 */ public TkModelResource Object;
        [NMS(Index = 2)]
        /* 0x94 */ public float Pitch;
        [NMS(Index = 4)]
        /* 0x98 */ public float Roll;
        [NMS(Index = 1)]
        /* 0x9C */ public float SpawnScale;
        [NMS(Index = 5)]
        /* 0xA0 */ public float UpOffset;
        [NMS(Index = 3)]
        /* 0xA4 */ public float Yaw;
    }
}
