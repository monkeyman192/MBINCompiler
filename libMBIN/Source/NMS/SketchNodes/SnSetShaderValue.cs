using System;
using System.Collections.Generic;
using System.Text;

using libMBIN.NMS.Toolkit;

namespace libMBIN.Source.NMS.SketchNodes
{
    [NMS(Size = 0x40)]
    public class SnSetShaderValue : NMSTemplate
    {
        [NMS(Size = 0x8)]
        /* 0x00 */ public byte[] Unknown0;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string Node;
        /* 0x18 */ public float Duration;
        [NMS(Size = 0x24)]
        /* 0x1C */ public byte[] Curve;
    }
}
