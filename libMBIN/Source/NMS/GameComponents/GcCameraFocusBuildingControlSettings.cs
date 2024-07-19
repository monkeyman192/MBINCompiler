using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA3094D1BD5E81E8, NameHash = 0x795297DD)]
    public class GcCameraFocusBuildingControlSettings : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public Vector2f ClampRange;
        [NMS(Index = 2)]
        /* 0x08 */ public float MaxStepRate;
        [NMS(Index = 3)]
        /* 0x0C */ public float MaxStepRateAccumulatedInput;
        [NMS(Index = 1)]
        /* 0x10 */ public float MinStepRate;
        [NMS(Index = 6)]
        /* 0x14 */ public float SmoothTime;
        [NMS(Index = 0)]
        /* 0x18 */ public float StepSize;
        [NMS(Index = 4)]
        /* 0x1C */ public bool Clamp;
        [NMS(Index = 7)]
        /* 0x1D */ public TkCurveType StepRateCurve;
    }
}
