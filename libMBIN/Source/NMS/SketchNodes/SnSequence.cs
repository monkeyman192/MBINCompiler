using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x0)]
    public class SnSequence : NMSTemplate
    {
        // Two varieties.
        // Variety 1:
        // OutNode: 'First'
        // IONode: 'Second'
        // Variety 2:
        // OutNode: 'First'
        // IONode: 'Second'
        // IONode: 'Third'
    }
}
