namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E2E4E9836123C36, NameHash = 0xDCBE648F7DED1A9F)]
    public class GcExpeditionHologramComponentData : NMSTemplate
    {
        /* 0x00 */ public Vector3f SpawnOffset;
        /* 0x10 */ public float CaptainScale;
        /* 0x14 */ public float FrigateScale;
        /* 0x18 */ public float HologramRotationSpeedDegPerSec;
    }
}
