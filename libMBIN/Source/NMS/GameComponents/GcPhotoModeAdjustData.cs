using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xD3E230DB23C781, NameHash = 0x6F5F53519B901CD4)]
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
