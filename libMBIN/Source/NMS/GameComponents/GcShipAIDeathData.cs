namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E0A7AFFD011AE23, NameHash = 0x52329167EAE2541C)]
    public class GcShipAIDeathData : NMSTemplate
    {
        /* 0x00 */ public float BrakeForce;
        /* 0x04 */ public float DroneDeathBoomTotalTime;
        /* 0x08 */ public float DroneDeathForce;
        /* 0x0C */ public float DroneDeathOffset;
        /* 0x10 */ public float DroneDeathTime;
        /* 0x14 */ public float DroneDeathTimeout;
        /* 0x18 */ public int DroneNumDeathBooms;
    }
}
