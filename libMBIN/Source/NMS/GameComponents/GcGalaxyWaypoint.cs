using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x38, GUID = 0xFF20FABD019768C3, NameHash = 0x562052A8272CC4A3)]
    public class GcGalaxyWaypoint : NMSTemplate
    {
        /* 0x00 */ public GcGalacticAddressData Address;
        /* 0x14 */ public GcGalaxyWaypointTypes Type;
        /* 0x18 */ public NMSString0x20 EventId;
    }
}
