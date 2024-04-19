namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6228F5D4E6A4CF1, NameHash = 0x88C0028CC5F47D1D)]
    public class GcSpaceshipTravelData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public float AvoidTime;
        /* 0x14 */ public float BoostSpeed;
        /* 0x18 */ public float DirectionBrake;
        /* 0x1C */ public float Falloff;
        /* 0x20 */ public float Force;
        /* 0x24 */ public float MaxSpeed;
        /* 0x28 */ public float MaxSpeedBrake;
        /* 0x2C */ public float MinHeight;
        /* 0x30 */ public float MinSpeed;
        /* 0x34 */ public float MinSpeedForce;
        /* 0x38 */ public float Roll;
        /* 0x3C */ public float TurnMax;
        /* 0x40 */ public float TurnMin;
        /* 0x44 */ public bool Hovering;
    }
}
