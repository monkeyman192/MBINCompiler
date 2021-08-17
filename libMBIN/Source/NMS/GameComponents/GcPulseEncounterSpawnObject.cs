using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x94, GUID = 0x1CAC5B1C7E541096, NameHash = 0x82C7C611E7625A21)]
    public class GcPulseEncounterSpawnObject : NMSTemplate
    {
        /* 0x00 */ public TkModelResource Object;
        /* 0x84 */ public float SpawnScale;
        /* 0x88 */ public float Pitch;
        /* 0x8C */ public float Yaw;
        /* 0x90 */ public float Roll;
    }
}
