using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE58BBB2467C4A948, NameHash = 0x47334DD09E6C3FE9)]
    public class GcSpaceMapObjectData : NMSTemplate     // size: 0x30
    {
        /* 0x00 */ public Colour Colour;
        /* 0x10 */ public float Radius;             // 40200000h
        /* 0x14 */ public float DistanceMin;        // 41200000h
        /* 0x18 */ public float DistanceRange;      // 43FA0000h
        /* 0x1C */ public float ScaleRange;         // 461C4000h
        /* 0x20 */ public float ScaleMagnitude;     // 3FB33333h
        /* 0x24 */ public float ScaleMin;           // 3ECCCCCDh
        /* 0x28 */ public bool Orient;              // 0
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x29 */ public byte[] EndPadding;
    }
}
