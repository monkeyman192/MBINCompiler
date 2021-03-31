using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x1)]
    public class SnValueAsBool : NMSTemplate
    {
        /* 0x0 */ public bool Invert;
        // IONode: Out: 0: Value; In: 0: "As Bool"
    }
}
