using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7CF5A6F3BDF45AFB, NameHash = 0xFED6D433FF718579)]
    public class GcProtectedLocation : NMSTemplate
    {
        /* 0x00 */ public Vector3f Location;
        /* 0x10 */ public float Radius;
    }
}
