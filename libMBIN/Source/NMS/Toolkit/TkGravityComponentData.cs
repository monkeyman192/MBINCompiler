using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBDFFADEBB13FAB24, NameHash = 0x3EB24220A135426C)]
    public class TkGravityComponentData : NMSTemplate
    {
        /* 0x0 */ public float Strength;
        /* 0x4 */ public float FalloffRadius;
    }
}
