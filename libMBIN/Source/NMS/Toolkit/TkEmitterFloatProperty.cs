using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB69761D004630E2, NameHash = 0xFE434BF3)]
    public class TkEmitterFloatProperty : NMSTemplate
    {
        [NMS(Index = 11)]
        /* 0x00 */ public NMSTemplate NextStage;
        // size: 0x3
        public enum AuthoringEnum : uint {
            FixedValue,
            RandomRangeFloat,
            Curves,
        }
        [NMS(Index = 0)]
        /* 0x10 */ public AuthoringEnum Authoring;
        [NMS(Index = 8)]
        /* 0x14 */ public float CurveBlendMidpoint;
        [NMS(Index = 7)]
        /* 0x18 */ public float CurveEndValue;
        [NMS(Index = 6)]
        /* 0x1C */ public float CurveMidValue;
        [NMS(Index = 5)]
        /* 0x20 */ public float CurveStartValue;
        [NMS(Index = 4)]
        /* 0x24 */ public float CurveVariation;
        [NMS(Index = 1)]
        /* 0x28 */ public float FixedValue;
        [NMS(Index = 3)]
        /* 0x2C */ public float MaxRandomValue;
        [NMS(Index = 2)]
        /* 0x30 */ public float MinRandomValue;
        [NMS(Index = 9)]
        /* 0x34 */ public TkCurveType Curve1Shape;
        [NMS(Index = 10)]
        /* 0x35 */ public TkCurveType Curve2Shape;
    }
}
