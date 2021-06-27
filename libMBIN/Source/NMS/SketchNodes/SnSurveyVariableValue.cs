using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x18)]
    public class SnSurveyVariableValue : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Variable;
        /* 0x10 */ public float Timeout;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] EndPadding;
        // IONode: Out: 0: Src, 1: Variable, 2: Timeout; In: 0: Value
    }
}
