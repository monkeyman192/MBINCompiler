using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3B502AF5CCB4C9F, NameHash = 0x6ECA0FF0AE9F9E21)]
    public class TkEmitterFloatProperty : NMSTemplate
    {
        public enum AuthoringEnum { FixedValue, RandomRangeFloat, Curves }
        /* 0x00 */ public AuthoringEnum Authoring;
        /* 0x04 */ public float FixedValue;
        /* 0x08 */ public float MinRandomValue;
        /* 0x0C */ public float MaxRandomValue;
        /* 0x10 */ public float CurveVariation;
        /* 0x14 */ public float CurveStartValue;
        /* 0x18 */ public float CurveMidValue;
        /* 0x1C */ public float CurveEndValue;
        /* 0x20 */ public float CurveBlendMidpoint;
        /* 0x24 */ public TkCurveType Curve1Shape;
        /* 0x28 */ public TkCurveType Curve2Shape;
    }
}
