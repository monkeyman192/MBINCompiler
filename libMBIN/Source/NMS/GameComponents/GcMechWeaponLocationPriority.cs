using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9DEBACF100FC47EA, NameHash = 0x3FADB12F28965B24)]
    public class GcMechWeaponLocationPriority : NMSTemplate
    {
        /* 0x0 */ public List<GcMechWeaponLocation> MechWeaponLocationPriority;
    }
}
