using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3CD41A091F9AB5C3, NameHash = 0x9CBA2290362425C1)]
    public class GcPlayerControlState : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public bool StickToGround;
        /* 0x18 */ public GcPlayerControlInput OverrideInput;
        /* 0x50 */ public NMSString0x10 OverrideCamera;
        /* 0x60 */ public List<NMSTemplate> Data;
    }
}
