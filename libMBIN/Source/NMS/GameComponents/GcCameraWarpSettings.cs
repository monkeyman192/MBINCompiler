using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7F93E2B83542FB8A, NameHash = 0x93903429)]
    public class GcCameraWarpSettings : NMSTemplate
    {
        [NMS(Index = 24)]
        /* 0x00 */ public float EntryLagCatchUpDelay;
        [NMS(Index = 25)]
        /* 0x04 */ public float EntryLagCatchUpTime;
        [NMS(Index = 21)]
        /* 0x08 */ public float EntryLagDistance;
        [NMS(Index = 22)]
        /* 0x0C */ public float EntryLagRiseTime;
        [NMS(Index = 30)]
        /* 0x10 */ public float ExitLagCatchUpDelay;
        [NMS(Index = 31)]
        /* 0x14 */ public float ExitLagCatchUpTime;
        [NMS(Index = 27)]
        /* 0x18 */ public float ExitLagDistance;
        [NMS(Index = 28)]
        /* 0x1C */ public float ExitLagRiseTime;
        [NMS(Index = 0)]
        /* 0x20 */ public float FocusPointDist;
        [NMS(Index = 15)]
        /* 0x24 */ public float OffsetXFrequency;
        [NMS(Index = 16)]
        /* 0x28 */ public float OffsetXPhase;
        [NMS(Index = 17)]
        /* 0x2C */ public float OffsetXRange;
        [NMS(Index = 13)]
        /* 0x30 */ public float OffsetYBias;
        [NMS(Index = 8)]
        /* 0x34 */ public float OffsetYFrequency_1;
        [NMS(Index = 9)]
        /* 0x38 */ public float OffsetYFrequency_2;
        [NMS(Index = 10)]
        /* 0x3C */ public float OffsetYPhase_1;
        [NMS(Index = 11)]
        /* 0x40 */ public float OffsetYPhase_2;
        [NMS(Index = 14)]
        /* 0x44 */ public float OffsetYRange;
        [NMS(Index = 12)]
        /* 0x48 */ public float OffsetYStartBias;
        [NMS(Index = 6)]
        /* 0x4C */ public float OffsetZBias;
        [NMS(Index = 1)]
        /* 0x50 */ public float OffsetZFrequency_1;
        [NMS(Index = 2)]
        /* 0x54 */ public float OffsetZFrequency_2;
        [NMS(Index = 3)]
        /* 0x58 */ public float OffsetZPhase_1;
        [NMS(Index = 4)]
        /* 0x5C */ public float OffsetZPhase_2;
        [NMS(Index = 7)]
        /* 0x60 */ public float OffsetZRange;
        [NMS(Index = 5)]
        /* 0x64 */ public float OffsetZStartBias;
        [NMS(Index = 19)]
        /* 0x68 */ public float RollRange;
        [NMS(Index = 20)]
        /* 0x6C */ public float YawnRange;
        [NMS(Index = 26)]
        /* 0x70 */ public TkCurveType EntryLagCatchUpCurve;
        [NMS(Index = 23)]
        /* 0x71 */ public TkCurveType EntryLagSurgeCurve;
        [NMS(Index = 32)]
        /* 0x72 */ public TkCurveType ExitLagCatchUpCurve;
        [NMS(Index = 29)]
        /* 0x73 */ public TkCurveType ExitLagSurgeCurve;
        [NMS(Index = 18)]
        /* 0x74 */ public TkCurveType OffsetXCurve;
    }
}
