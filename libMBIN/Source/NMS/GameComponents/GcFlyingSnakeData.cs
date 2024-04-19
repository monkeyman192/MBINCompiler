namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x912B8C84F2D13E72, NameHash = 0x8AE34D6AD8F2EB14)]
    public class GcFlyingSnakeData : NMSTemplate
    {
        /* 0x00 */ public float AirThickness;
        /* 0x04 */ public float AltitudeSinAmp;
        /* 0x08 */ public float AltitudeSinPeriod;
        /* 0x0C */ public float ApproachBaitSpeed;
        /* 0x10 */ public float AscendDescendSpeed;
        /* 0x14 */ public float BarrelRollCount;
        /* 0x18 */ public float BarrelRollSpawnDelay;
        /* 0x1C */ public float BarrelRollSpeed;
        /* 0x20 */ public float CircleSpeed;
        /* 0x24 */ public float DefaultCircleDistance;
        /* 0x28 */ public float RiseDelay;
        /* 0x2C */ public float RiseHeight;
        /* 0x30 */ public float RiseTime;
        /* 0x34 */ public float TailStiffness;
        /* 0x38 */ public float TwistLimit;
        /* 0x3C */ public float WindForce;
    }
}
