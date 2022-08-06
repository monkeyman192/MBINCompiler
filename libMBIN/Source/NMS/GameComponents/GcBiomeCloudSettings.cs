using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFB212B0D1A5AF93A, NameHash = 0x7F6183B8DF97F0B3)]
    public class GcBiomeCloudSettings : NMSTemplate
    {
        /* 0x00 */ public float MinCover;
        /* 0x04 */ public float MaxCover;
        /* 0x08 */ public float MinVariance;
        /* 0x0C */ public float MaxVariance;
        /* 0x10 */ public float MinRateOfChange;
        /* 0x14 */ public float MaxRateOfChange;
        /* 0x18 */ public float MinRatio;
        /* 0x1C */ public float MaxRatio;
        /* 0x20 */ public float TendencyTowardsBeingCloudy;
        /* 0x30 */ public Colour StormCloudTopColour;
        /* 0x40 */ public Colour StormCloudBottomColour;
    }
}
