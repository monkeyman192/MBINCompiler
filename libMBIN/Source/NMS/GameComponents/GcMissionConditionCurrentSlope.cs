using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x31BD7D95C132F5F9, NameHash = 0x5B37185)]
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
