namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAA8CFAD7052E64F3, NameHash = 0x7F6183B8DF97F0B3)]
    public class GcBiomeCloudSettings : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x00 */ public Colour StormCloudBottomColour;
        [NMS(Index = 9)]
        /* 0x10 */ public Colour StormCloudTopColour;
        [NMS(Index = 1)]
        /* 0x20 */ public float MaxCover;
        [NMS(Index = 5)]
        /* 0x24 */ public float MaxRateOfChange;
        [NMS(Index = 7)]
        /* 0x28 */ public float MaxRatio;
        [NMS(Index = 3)]
        /* 0x2C */ public float MaxVariance;
        [NMS(Index = 0)]
        /* 0x30 */ public float MinCover;
        [NMS(Index = 4)]
        /* 0x34 */ public float MinRateOfChange;
        [NMS(Index = 6)]
        /* 0x38 */ public float MinRatio;
        [NMS(Index = 2)]
        /* 0x3C */ public float MinVariance;
        [NMS(Index = 8)]
        /* 0x40 */ public float TendencyTowardsBeingCloudy;
    }
}
