namespace MBINCompiler.Models.Structs
{
    public class GcSpaceshipTravelData : NMSTemplate //size = 0x48
    {
        /* 0x000 */ public float MinSpeed;
        /* 0x004 */ public float MaxSpeed;
        /* 0x008 */ public float BoostSpeed;
        /* 0x00C */ public float Force;
        /* 0x010 */ public float MinSpeedForce;
        /* 0x014 */ public float TurnMin;
		/* 0x018 */ public float TurnMax;
		/* 0x01C */ public float DirectionBrake;
		/* 0x020 */ public float PlanetMinSpeed;
		/* 0x024 */ public float PlanetMaxSpeed;
		/* 0x028 */ public float PlanetBoostSpeed;
		/* 0x02C */ public float PlanetForce;
		/* 0x030 */ public float PlanetTurnMin;
		/* 0x034 */ public float PlanetTurnMax;
		/* 0x038 */ public float PlanetDirectionBrake;
		/* 0x03C */ public float Falloff;
		/* 0x040 */ public float Roll;
		/* 0x044 */ public float MinHeight;
    }
}
