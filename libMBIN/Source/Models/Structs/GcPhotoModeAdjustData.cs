using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x18)]
    public class GcPhotoModeAdjustData : NMSTemplate
    {
        /* 0x00 */ public float AdjustMin;
        /* 0x04 */ public TkCurveType AdjustMinCurve;
        /* 0x08 */ public float AdjustMax;                         // 40000000h
        /* 0x0C */ public float AdjustMaxRange;                    // 40000000h
        /* 0x10 */ public TkCurveType AdjustMaxCurve;
        /* 0x14 */ public bool Inverted;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x15 */ public byte[] EndPadding;
    }
}
