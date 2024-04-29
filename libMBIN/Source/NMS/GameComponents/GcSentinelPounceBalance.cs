namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC5A40C7D2FCE7543, NameHash = 0xC9E78F2D1358073D)]
    public class GcSentinelPounceBalance : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public float MaxAngle;
        [NMS(Index = 6)]
        /* 0x04 */ public float MaxFireRateScore;
        [NMS(Index = 1)]
        /* 0x08 */ public float MaxRange;
        [NMS(Index = 5)]
        /* 0x0C */ public float MinFireRateScore;
        [NMS(Index = 2)]
        /* 0x10 */ public float MinRange;
        [NMS(Index = 3)]
        /* 0x14 */ public float MinTimeBetweenPounces;
        [NMS(Index = 7)]
        /* 0x18 */ public float OtherPounceTimeMultiplier;
        [NMS(Index = 4)]
        /* 0x1C */ public float PounceTimeFireRateScoreExtra;
    }
}
