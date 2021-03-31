using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x0)]
    public class SnSequence : NMSTemplate
    {
        // IONode1: Out: "First"
        // OutNode2: "Second"
        // For variant > 0, each one has a subsequent OutNode named "Third", 'Forth", etc...
        // ie. Variant = 1 => one OutNode called "Third"
        // Variant = 2 => two OutNodes called "Third" and "Forth".
    }
}
