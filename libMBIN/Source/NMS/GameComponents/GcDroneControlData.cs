using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1D1F2601FEC961D9, NameHash = 0xF561E496C1DF269E)]
    public class GcDroneControlData : NMSTemplate
    {
        /* 0x00 */ public float MaxSpeed;
        /* 0x04 */ public float Strength;
        /* 0x08 */ public float DirectionBrake;
        /* 0x0C */ public float MinHeight;
        /* 0x10 */ public float MaxHeight;
        /* 0x14 */ public float MaxPitch;
        /* 0x18 */ public float HeightAdjustStrength;
        /* 0x1C */ public float HeightAdjustDownStrength;
        /* 0x20 */ public float LookStrength;
        /* 0x24 */ public float StopTime;
        /* 0x28 */ public float RepelForce;
        /* 0x2C */ public float RepelRange;
    }
}
