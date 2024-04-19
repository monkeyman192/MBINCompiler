using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAE9AE9B2CD954C82, NameHash = 0xBEBEB02AB2408708)]
    public class GcMissionConditionCurrentSlope : NMSTemplate
    {
        /* 0x0 */ public float SlopeAngle;
        /* 0x4 */ public TkEqualityEnum Test;
        /* 0x8 */ public bool Abs;
    }
}
