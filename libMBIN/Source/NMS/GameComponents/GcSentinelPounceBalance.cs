namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E2342174D89609B, NameHash = 0xC9E78F2D1358073D)]
    public class GcSentinelPounceBalance : NMSTemplate
    {
        /* 0x00 */ public float MaxAngle;
        /* 0x04 */ public float MaxFireRateScore;
        /* 0x08 */ public float MaxRange;
        /* 0x0C */ public float MinFireRateScore;
        /* 0x10 */ public float MinRange;
        /* 0x14 */ public float MinTimeBetweenPounces;
        /* 0x18 */ public float OtherPounceTimeMultiplier;
        /* 0x1C */ public float PounceTimeFireRateScoreExtra;
    }
}
