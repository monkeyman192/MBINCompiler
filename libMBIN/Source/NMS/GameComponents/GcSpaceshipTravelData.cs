using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0xA681CB4CFB4D2B6B, NameHash = 0x88C0028CC5F47D1D)]
    public class GcSpaceshipTravelData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public float MinSpeed;
        /* 0x14 */ public float MaxSpeed;
        /* 0x18 */ public float BoostSpeed;
        /* 0x1C */ public float Force;
        /* 0x20 */ public float MinSpeedForce;
        /* 0x24 */ public float TurnMin;
		/* 0x28 */ public float TurnMax;
		/* 0x2C */ public float DirectionBrake;
		/* 0x30 */ public float PlanetMinSpeed;
		/* 0x34 */ public float PlanetMaxSpeed;
		/* 0x38 */ public float PlanetBoostSpeed;
		/* 0x3C */ public float PlanetForce;
		/* 0x40 */ public float PlanetTurnMin;
		/* 0x44 */ public float PlanetTurnMax;
		/* 0x48 */ public float PlanetDirectionBrake;
		/* 0x4C */ public float Falloff;
		/* 0x50 */ public float Roll;
		/* 0x54 */ public float MinHeight;
        /* 0x58 */ public float AvoidTime;
        /* 0x5C */ public bool Hovering;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x5D */ public byte[] EndPadding;
    }
}
