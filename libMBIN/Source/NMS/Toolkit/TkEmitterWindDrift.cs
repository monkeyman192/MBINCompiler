using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1B9F59C95103EA24, NameHash = 0x65E2FA9B)]
    public class TkEmitterWindDrift : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public float CurveBlendMidpoint;
        [NMS(Index = 6)]
        /* 0x04 */ public float CurveEndValue;
        [NMS(Index = 5)]
        /* 0x08 */ public float CurveMidValue;
        [NMS(Index = 4)]
        /* 0x0C */ public float CurveStartValue;
        [NMS(Index = 2)]
        /* 0x10 */ public float Speed;
        [NMS(Index = 0)]
        /* 0x14 */ public float Strength;
        [NMS(Index = 8)]
        /* 0x18 */ public TkCurveType Curve1Shape;
        [NMS(Index = 9)]
        /* 0x19 */ public TkCurveType Curve2Shape;
        [NMS(Index = 3)]
        /* 0x1A */ public bool LimitEmitterLifetime;
        [NMS(Index = 1)]
        /* 0x1B */ public bool LimitEmitterSpeed;
    }
}
