namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9CDEC17EFBF2E9DD, NameHash = 0x88C0028CC5F47D1D)]
    public class GcSpaceshipTravelData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 13)]
        /* 0x10 */ public float AvoidTime;
        [NMS(Index = 3)]
        /* 0x14 */ public float BoostSpeed;
        [NMS(Index = 8)]
        /* 0x18 */ public float DirectionBrake;
        [NMS(Index = 10)]
        /* 0x1C */ public float Falloff;
        [NMS(Index = 4)]
        /* 0x20 */ public float Force;
        [NMS(Index = 2)]
        /* 0x24 */ public float MaxSpeed;
        [NMS(Index = 9)]
        /* 0x28 */ public float MaxSpeedBrake;
        [NMS(Index = 12)]
        /* 0x2C */ public float MinHeight;
        [NMS(Index = 1)]
        /* 0x30 */ public float MinSpeed;
        [NMS(Index = 5)]
        /* 0x34 */ public float MinSpeedForce;
        [NMS(Index = 11)]
        /* 0x38 */ public float Roll;
        [NMS(Index = 7)]
        /* 0x3C */ public float TurnMax;
        [NMS(Index = 6)]
        /* 0x40 */ public float TurnMin;
        [NMS(Index = 14)]
        /* 0x44 */ public bool Hovering;
    }
}
