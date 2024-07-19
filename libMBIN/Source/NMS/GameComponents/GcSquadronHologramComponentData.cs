namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x422B2515008FCC35, NameHash = 0x316E0A55)]
    public class GcSquadronHologramComponentData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector3f SpawnOffset;
        [NMS(Index = 0)]
        /* 0x10 */ public float HologramRotationSpeedDegPerSec;
        [NMS(Index = 1)]
        /* 0x14 */ public float PilotScale;
        [NMS(Index = 3)]
        /* 0x18 */ public float SpawnRotation;
    }
}
