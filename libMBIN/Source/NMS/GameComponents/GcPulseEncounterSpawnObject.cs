using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDBD6136FBBF407B7, NameHash = 0x82C7C611E7625A21)]
    public class GcPulseEncounterSpawnObject : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 TriggerActionOnSpawn;
        /* 0x10 */ public TkModelResource Object;
        /* 0x94 */ public float Pitch;
        /* 0x98 */ public float Roll;
        /* 0x9C */ public float SpawnScale;
        /* 0xA0 */ public float UpOffset;
        /* 0xA4 */ public float Yaw;
    }
}
