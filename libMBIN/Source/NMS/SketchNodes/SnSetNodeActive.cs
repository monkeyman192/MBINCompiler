using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x18)]
    public class SnSetNodeActive : NMSTemplate
    {
        /* 0x00 */ public bool Active;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x01 */ public byte[] Padding1;
        [NMS(Size = 0x10)]
        /* 0x80 */ public string Name;
        // IONode: Out: 0: Src, 1: Node, 2: Active
    }
}
