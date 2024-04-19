using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x910D11CA9F5339A1, NameHash = 0x72EE2F7B202E1811)]
    public class GcCameraWarpSettings : NMSTemplate
    {
        /* 0x00 */ public float FocusPointDist;
        /* 0x04 */ public float OffsetXFrequency;
        /* 0x08 */ public float OffsetXPhase;
        /* 0x0C */ public float OffsetXRange;
        /* 0x10 */ public float OffsetYBias;
        /* 0x14 */ public float OffsetYFrequency_1;
        /* 0x18 */ public float OffsetYFrequency_2;
        /* 0x1C */ public float OffsetYPhase_1;
        /* 0x20 */ public float OffsetYPhase_2;
        /* 0x24 */ public float OffsetYRange;
        /* 0x28 */ public float OffsetYStartBias;
        /* 0x2C */ public float OffsetZBias;
        /* 0x30 */ public float OffsetZFrequency_1;
        /* 0x34 */ public float OffsetZFrequency_2;
        /* 0x38 */ public float OffsetZPhase_1;
        /* 0x3C */ public float OffsetZPhase_2;
        /* 0x40 */ public float OffsetZRange;
        /* 0x44 */ public float OffsetZStartBias;
        /* 0x48 */ public float RollRange;
        /* 0x4C */ public float YawnRange;
        /* 0x50 */ public TkCurveType OffsetXCurve;
    }
}
