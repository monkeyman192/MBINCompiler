namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x245F110C52EE30E6, NameHash = 0xBC256EFD)]
    public class GcShipAIDeathData : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public float BrakeForce;
        [NMS(Index = 2)]
        /* 0x04 */ public float DroneDeathBoomTotalTime;
        [NMS(Index = 1)]
        /* 0x08 */ public float DroneDeathForce;
        [NMS(Index = 3)]
        /* 0x0C */ public float DroneDeathOffset;
        [NMS(Index = 0)]
        /* 0x10 */ public float DroneDeathTime;
        [NMS(Index = 5)]
        /* 0x14 */ public float DroneDeathTimeout;
        [NMS(Index = 4)]
        /* 0x18 */ public int DroneNumDeathBooms;
    }
}
