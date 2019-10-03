using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1A17963717B304A1, NameHash = 0x8AE34D6AD8F2EB14)]
    public class GcFlyingSnakeData : NMSTemplate 
    {
		  /* 0x00 */ public float CircleSpeed;
		  /* 0x04 */ public float ApproachBaitSpeed;
		  /* 0x08 */ public float DefaultCircleDistance;
		  /* 0x0C */ public float BarrelRollSpawnDelay;
		  /* 0x10 */ public float BarrelRollCount;
		  /* 0x14 */ public float BarrelRollSpeed;
		  /* 0x18 */ public float RiseDelay;
		  /* 0x1C */ public float RiseHeight;
		  /* 0x20 */ public float RiseTime;
		  /* 0x24 */ public float AirThickness;
		  /* 0x28 */ public float WindForce;
		  /* 0x2C */ public float TailStiffness;
		  /* 0x30 */ public float TwistLimit;
		  /* 0x34 */ public float AltitudeSinPeriod;
		  /* 0x38 */ public float AltitudeSinAmp;
		  /* 0x3C */ public float AscendDescendSpeed;
    }
}
