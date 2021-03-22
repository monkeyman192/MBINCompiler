using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0xC)]
    public class SnVector3f : NMSTemplate
    {
        public float X;
        public float Y;
        public float Z;
    }
}
