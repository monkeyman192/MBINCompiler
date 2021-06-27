using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x10)]
    public class SnStopCameraShake : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ShakeId;
        // IoNode: Out: 0: Src, 1: ShakeId
    }
}
