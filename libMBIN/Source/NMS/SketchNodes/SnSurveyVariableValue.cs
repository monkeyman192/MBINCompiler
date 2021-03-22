using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x18)]
    public class SnSurveyVariableValue : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Variable;
        /* 0x10 */ public float Timeout;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] EndPadding;
        // OutNode: 'Value'
    }
}
