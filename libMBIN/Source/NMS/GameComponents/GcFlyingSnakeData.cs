namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD9FCDF892789C007, NameHash = 0xB14955DB)]
    public class GcFlyingSnakeData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public float AirThickness;
        [NMS(Index = 14)]
        /* 0x04 */ public float AltitudeSinAmp;
        [NMS(Index = 13)]
        /* 0x08 */ public float AltitudeSinPeriod;
        [NMS(Index = 1)]
        /* 0x0C */ public float ApproachBaitSpeed;
        [NMS(Index = 15)]
        /* 0x10 */ public float AscendDescendSpeed;
        [NMS(Index = 4)]
        /* 0x14 */ public float BarrelRollCount;
        [NMS(Index = 3)]
        /* 0x18 */ public float BarrelRollSpawnDelay;
        [NMS(Index = 5)]
        /* 0x1C */ public float BarrelRollSpeed;
        [NMS(Index = 0)]
        /* 0x20 */ public float CircleSpeed;
        [NMS(Index = 2)]
        /* 0x24 */ public float DefaultCircleDistance;
        [NMS(Index = 6)]
        /* 0x28 */ public float RiseDelay;
        [NMS(Index = 7)]
        /* 0x2C */ public float RiseHeight;
        [NMS(Index = 8)]
        /* 0x30 */ public float RiseTime;
        [NMS(Index = 11)]
        /* 0x34 */ public float TailStiffness;
        [NMS(Index = 12)]
        /* 0x38 */ public float TwistLimit;
        [NMS(Index = 10)]
        /* 0x3C */ public float WindForce;
    }
}
