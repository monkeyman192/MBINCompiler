using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x809E13A5E8133137, NameHash = 0xF29EC845)]
    public class GcMechWeaponLocationPriority : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcMechWeaponLocation> MechWeaponLocationPriority;
    }
}
