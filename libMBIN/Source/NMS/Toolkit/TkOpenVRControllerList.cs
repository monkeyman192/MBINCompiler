using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5E0C04372645E67E, NameHash = 0x4E1552E2)]
    public class TkOpenVRControllerList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkOpenVRControllerLookup> Devices;
    }
}
