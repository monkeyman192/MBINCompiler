namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xABDDD41E52F1ADE6, NameHash = 0xDCBE648F7DED1A9F)]
    public class GcExpeditionHologramComponentData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public Vector3f SpawnOffset;
        [NMS(Index = 1)]
        /* 0x10 */ public float CaptainScale;
        [NMS(Index = 2)]
        /* 0x14 */ public float FrigateScale;
        [NMS(Index = 0)]
        /* 0x18 */ public float HologramRotationSpeedDegPerSec;
    }
}
