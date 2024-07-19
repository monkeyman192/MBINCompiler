using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x44FB1E298D835821, NameHash = 0x93903429)]
    public class GcCameraWarpSettings : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public float FocusPointDist;
        [NMS(Index = 15)]
        /* 0x04 */ public float OffsetXFrequency;
        [NMS(Index = 16)]
        /* 0x08 */ public float OffsetXPhase;
        [NMS(Index = 17)]
        /* 0x0C */ public float OffsetXRange;
        [NMS(Index = 13)]
        /* 0x10 */ public float OffsetYBias;
        [NMS(Index = 8)]
        /* 0x14 */ public float OffsetYFrequency_1;
        [NMS(Index = 9)]
        /* 0x18 */ public float OffsetYFrequency_2;
        [NMS(Index = 10)]
        /* 0x1C */ public float OffsetYPhase_1;
        [NMS(Index = 11)]
        /* 0x20 */ public float OffsetYPhase_2;
        [NMS(Index = 14)]
        /* 0x24 */ public float OffsetYRange;
        [NMS(Index = 12)]
        /* 0x28 */ public float OffsetYStartBias;
        [NMS(Index = 6)]
        /* 0x2C */ public float OffsetZBias;
        [NMS(Index = 1)]
        /* 0x30 */ public float OffsetZFrequency_1;
        [NMS(Index = 2)]
        /* 0x34 */ public float OffsetZFrequency_2;
        [NMS(Index = 3)]
        /* 0x38 */ public float OffsetZPhase_1;
        [NMS(Index = 4)]
        /* 0x3C */ public float OffsetZPhase_2;
        [NMS(Index = 7)]
        /* 0x40 */ public float OffsetZRange;
        [NMS(Index = 5)]
        /* 0x44 */ public float OffsetZStartBias;
        [NMS(Index = 19)]
        /* 0x48 */ public float RollRange;
        [NMS(Index = 20)]
        /* 0x4C */ public float YawnRange;
        [NMS(Index = 18)]
        /* 0x50 */ public TkCurveType OffsetXCurve;
    }
}
