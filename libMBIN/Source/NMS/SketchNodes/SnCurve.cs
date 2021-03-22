using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x24)]
    public class SnCurve : NMSTemplate
    {
        // WIP
        // I think this is possibly given to the shaders `gAcesCurveParams`?
        [NMS(Size = 0x12)]
        public ushort[] Points;
    }
}
