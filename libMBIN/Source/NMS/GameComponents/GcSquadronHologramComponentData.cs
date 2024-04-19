namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x11879F8426DFCD89, NameHash = 0x8E4A63D8D3818019)]
    public class GcSquadronHologramComponentData : NMSTemplate
    {
        /* 0x00 */ public Vector3f SpawnOffset;
        /* 0x10 */ public float HologramRotationSpeedDegPerSec;
        /* 0x14 */ public float PilotScale;
        /* 0x18 */ public float SpawnRotation;
    }
}
