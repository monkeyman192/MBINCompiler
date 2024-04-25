namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x406F4438F098A30D, NameHash = 0xE607B9EEA91E2AD5)]
    public class GcSpaceshipAvoidanceData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public float EndRadiusMultiplier;
        [NMS(Index = 3)]
        /* 0x04 */ public float Force;
        [NMS(Index = 0)]
        /* 0x08 */ public int NumRays;
        [NMS(Index = 1)]
        /* 0x0C */ public float RayMinRange;
        [NMS(Index = 2)]
        /* 0x10 */ public float RaySpeedTime;
        [NMS(Index = 6)]
        /* 0x14 */ public float SpeedInterp;
        [NMS(Index = 7)]
        /* 0x18 */ public float SpeedInterpMinSpeed;
        [NMS(Index = 8)]
        /* 0x1C */ public float SpeedInterpRange;
        [NMS(Index = 4)]
        /* 0x20 */ public float StartRadiusMultiplier;
    }
}
