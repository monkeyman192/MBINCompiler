using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x18)]
    public class SnCameraShake : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ShakeId;
        /* 0x10 */ public float Range;
        [NMS(Size = 0x4, Ignore = true, DefaultValue = new byte[2] {0x40, 0x3})]    // This may be an actual value, however it isn't in the exe...
        /* 0x14 */ public byte[] EndPadding;
        // IONode: Out: 0: Src, 1: ShakeId, 2: Range
    }
}
