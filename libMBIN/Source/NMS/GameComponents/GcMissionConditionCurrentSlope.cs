using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x48701375371714C6, NameHash = 0xBEBEB02AB2408708)]
    public class GcMissionConditionCurrentSlope : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float SlopeAngle;
        [NMS(Index = 2)]
        /* 0x4 */ public TkEqualityEnum Test;
        [NMS(Index = 1)]
        /* 0x8 */ public bool Abs;
    }
}
