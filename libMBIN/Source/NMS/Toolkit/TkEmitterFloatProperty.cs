using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x75CC7A3D09A0F329, NameHash = 0x6ECA0FF0AE9F9E21)]
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
        /* 0x50 */ public AuthoringEnum Authoring;
        [NMS(Index = 8)]
        /* 0x54 */ public float CurveBlendMidpoint;
        [NMS(Index = 7)]
        /* 0x58 */ public float CurveEndValue;
        [NMS(Index = 6)]
        /* 0x5C */ public float CurveMidValue;
        [NMS(Index = 5)]
        /* 0x60 */ public float CurveStartValue;
        [NMS(Index = 4)]
        /* 0x64 */ public float CurveVariation;
        [NMS(Index = 1)]
        /* 0x68 */ public float FixedValue;
        [NMS(Index = 3)]
        /* 0x6C */ public float MaxRandomValue;
        [NMS(Index = 2)]
        /* 0x70 */ public float MinRandomValue;
        [NMS(Index = 9)]
        /* 0x74 */ public TkCurveType Curve1Shape;
        [NMS(Index = 10)]
        /* 0x75 */ public TkCurveType Curve2Shape;
    }
}
