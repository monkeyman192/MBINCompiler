using System;
using System.Collections.Generic;
using System.Text;
using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x40)]
    public class SnMathsFunction : NMSTemplate
    {
        [NMS(Size = 0x40)]
        /* 0x0 */ public string Expression;
        // OutNode: 'Value'
    }
}
