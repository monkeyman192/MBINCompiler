using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFE3D4F835060B1A6, NameHash = 0xBEBEB02AB2408708)]
    public class GcMissionConditionCurrentSlope : NMSTemplate
    {
        /* 0x0 */ public float SlopeAngle;
        /* 0x4 */ public bool Abs;
        /* 0x8 */ public TkEqualityEnum Test;
    }
}
