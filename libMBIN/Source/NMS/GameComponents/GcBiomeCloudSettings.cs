namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x75E90F27EF881AAF, NameHash = 0xFD99BE0B)]
    public class GcBiomeCloudSettings : NMSTemplate
    {
        [NMS(Index = 14)]
        /* 0x00 */ public Colour StormCloudBottomColour;
        [NMS(Index = 13)]
        /* 0x10 */ public Colour StormCloudTopColour;
        [NMS(Index = 5)]
        /* 0x20 */ public float MaxCover;
        [NMS(Index = 1)]
        /* 0x24 */ public float MaxCoverage;
        [NMS(Index = 3)]
        /* 0x28 */ public float MaxCoverageVariance;
        [NMS(Index = 9)]
        /* 0x2C */ public float MaxRateOfChange;
        [NMS(Index = 11)]
        /* 0x30 */ public float MaxRatio;
        [NMS(Index = 7)]
        /* 0x34 */ public float MaxVariance;
        [NMS(Index = 4)]
        /* 0x38 */ public float MinCover;
        [NMS(Index = 0)]
        /* 0x3C */ public float MinCoverage;
        [NMS(Index = 2)]
        /* 0x40 */ public float MinCoverageVariance;
        [NMS(Index = 8)]
        /* 0x44 */ public float MinRateOfChange;
        [NMS(Index = 10)]
        /* 0x48 */ public float MinRatio;
        [NMS(Index = 6)]
        /* 0x4C */ public float MinVariance;
        [NMS(Index = 12)]
        /* 0x50 */ public float TendencyTowardsBeingCloudy;
    }
}
