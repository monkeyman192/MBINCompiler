namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEB33ADDD4D6D72BA, NameHash = 0xF561E496C1DF269E)]
    public class GcDroneControlData : NMSTemplate
    {
        /* 0x00 */ public float DirectionBrake;
        /* 0x04 */ public float HeightAdjustDownStrength;
        /* 0x08 */ public float HeightAdjustStrength;
        /* 0x0C */ public float LookStrength;
        /* 0x10 */ public float MaxHeight;
        /* 0x14 */ public float MaxPitch;
        /* 0x18 */ public float MaxSpeed;
        /* 0x1C */ public float MinHeight;
        /* 0x20 */ public float RepelForce;
        /* 0x24 */ public float RepelRange;
        /* 0x28 */ public float StopTime;
        /* 0x2C */ public float Strength;
    }
}
