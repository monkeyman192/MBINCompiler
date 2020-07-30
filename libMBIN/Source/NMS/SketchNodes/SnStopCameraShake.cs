using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.Source.NMS.SketchNodes
{
    [NMS(Size = 0x10)]
    public class SnStopCameraShake : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string ShakeId;
        // OutNode: Unnamed
    }
}
