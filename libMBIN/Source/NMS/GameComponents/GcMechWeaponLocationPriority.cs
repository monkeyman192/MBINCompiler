using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x14CCF0AF27C8A777, NameHash = 0x3FADB12F28965B24)]
    public class GcMechWeaponLocationPriority : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcMechWeaponLocation> MechWeaponLocationPriority;
    }
}
