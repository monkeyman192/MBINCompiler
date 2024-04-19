using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6E3C701067AF1AF0, NameHash = 0x6ECA0FF0AE9F9E21)]
    public class TkEmitterFloatProperty : NMSTemplate
    {
        /* 0x00 */ public NMSTemplate NextStage;
        // size: 0x3
        public enum AuthoringEnum : uint {
            FixedValue,
            RandomRangeFloat,
            Curves,
        }
        /* 0x50 */ public AuthoringEnum Authoring;
        /* 0x54 */ public float CurveBlendMidpoint;
        /* 0x58 */ public float CurveEndValue;
        /* 0x5C */ public float CurveMidValue;
        /* 0x60 */ public float CurveStartValue;
        /* 0x64 */ public float CurveVariation;
        /* 0x68 */ public float FixedValue;
        /* 0x6C */ public float MaxRandomValue;
        /* 0x70 */ public float MinRandomValue;
        /* 0x74 */ public TkCurveType Curve1Shape;
        /* 0x75 */ public TkCurveType Curve2Shape;
    }
}
