using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4E7B4788BFA708C2, NameHash = 0x3246DB9846FF8B70)]
    public class GcPlayerCommunicatorMessageWeighted : NMSTemplate
    {
        /* 0x00 */ public GcPlayerCommunicatorMessage Message;
        /* 0x50 */ public int Weight;
    }
}
