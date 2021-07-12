using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x10)]
    public class SnOnVariableChanged : NMSTemplate
    {
        /* 0x0 */ public SnNMSString0x10 Variable;
        // OutNode1: 0: "Old Value"
        // OutNode2: 0: "New Value"
    }
}
