namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAA8CFAD7052E64F3, NameHash = 0x7F6183B8DF97F0B3)]
    public class GcBiomeCloudSettings : NMSTemplate
    {
        /* 0x00 */ public Colour StormCloudBottomColour;
        /* 0x10 */ public Colour StormCloudTopColour;
        /* 0x20 */ public float MaxCover;
        /* 0x24 */ public float MaxRateOfChange;
        /* 0x28 */ public float MaxRatio;
        /* 0x2C */ public float MaxVariance;
        /* 0x30 */ public float MinCover;
        /* 0x34 */ public float MinRateOfChange;
        /* 0x38 */ public float MinRatio;
        /* 0x3C */ public float MinVariance;
        /* 0x40 */ public float TendencyTowardsBeingCloudy;
    }
}
