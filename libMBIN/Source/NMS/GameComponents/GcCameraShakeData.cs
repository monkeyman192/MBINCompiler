using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA1B74654E438150, NameHash = 0x381A76E400DE3EE7)]
    public class GcCameraShakeData : NMSTemplate
    {
        /* 0x00 */ public GcCameraShakeMechanicalData MechanicalData;
        /* 0x70 */ public NMSString0x10 Name;
        /* 0x80 */ public GcCameraShakeCapturedData CapturedData;
        /* 0x94 */ public float DecayRate;
        /* 0x98 */ public float FovFrequency;
        /* 0x9C */ public float FovStrength;
        /* 0xA0 */ public float StrengthScale;
        /* 0xA4 */ public float ThirdPersonDamp;
        /* 0xA8 */ public float TimeStart;
        /* 0xAC */ public float TotalTime;
        /* 0xB0 */ public float VRStrength;
    }
}
