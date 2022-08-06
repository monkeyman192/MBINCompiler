using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9DC01163E11A02B0, NameHash = 0x7643AB5C62562264)]
    public class GcDroneGun : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 Locator;
        /* 0x20 */ public NMSString0x10 Anim;
    }
}
