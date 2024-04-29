using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x635B8D3520AE03CE, NameHash = 0x381A76E400DE3EE7)]
    public class GcCameraShakeData : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x00 */ public GcCameraShakeMechanicalData MechanicalData;
        [NMS(Index = 0)]
        /* 0x70 */ public NMSString0x10 Name;
        [NMS(Index = 7)]
        /* 0x80 */ public GcCameraShakeCapturedData CapturedData;
        [NMS(Index = 3)]
        /* 0x94 */ public float DecayRate;
        [NMS(Index = 10)]
        /* 0x98 */ public float FovFrequency;
        [NMS(Index = 9)]
        /* 0x9C */ public float FovStrength;
        [NMS(Index = 4)]
        /* 0xA0 */ public float StrengthScale;
        [NMS(Index = 5)]
        /* 0xA4 */ public float ThirdPersonDamp;
        [NMS(Index = 1)]
        /* 0xA8 */ public float TimeStart;
        [NMS(Index = 2)]
        /* 0xAC */ public float TotalTime;
        [NMS(Index = 6)]
        /* 0xB0 */ public float VRStrength;
    }
}
