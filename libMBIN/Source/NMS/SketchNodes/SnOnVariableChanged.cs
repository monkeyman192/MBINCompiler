using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x10)]
    public class SnOnVariableChanged : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x0 */ public string Variable;
        // OutNode1: 0: "Old Value"
        // OutNode2: 0: "New Value"
    }
}
