namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEB33ADDD4D6D72BA, NameHash = 0xF561E496C1DF269E)]
    public class GcDroneControlData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public float DirectionBrake;
        [NMS(Index = 7)]
        /* 0x04 */ public float HeightAdjustDownStrength;
        [NMS(Index = 6)]
        /* 0x08 */ public float HeightAdjustStrength;
        [NMS(Index = 8)]
        /* 0x0C */ public float LookStrength;
        [NMS(Index = 4)]
        /* 0x10 */ public float MaxHeight;
        [NMS(Index = 5)]
        /* 0x14 */ public float MaxPitch;
        [NMS(Index = 0)]
        /* 0x18 */ public float MaxSpeed;
        [NMS(Index = 3)]
        /* 0x1C */ public float MinHeight;
        [NMS(Index = 10)]
        /* 0x20 */ public float RepelForce;
        [NMS(Index = 11)]
        /* 0x24 */ public float RepelRange;
        [NMS(Index = 9)]
        /* 0x28 */ public float StopTime;
        [NMS(Index = 1)]
        /* 0x2C */ public float Strength;
    }
}
