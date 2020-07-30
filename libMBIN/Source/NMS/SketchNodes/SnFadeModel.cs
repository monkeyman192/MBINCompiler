using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.Source.NMS.SketchNodes
{
    [NMS(Size = 0x8)]
    public class SnFadeModel : NMSTemplate
    {
        /* 0x0 */ public bool FadeIn;
        /* 0x4 */ public float Seconds;
        // OutNode: Unnamed
    }
}
