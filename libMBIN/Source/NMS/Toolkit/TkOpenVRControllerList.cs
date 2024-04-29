using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xFC3EA3FCE006970E, NameHash = 0x9BF04097261BBFEA)]
    public class TkOpenVRControllerList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkOpenVRControllerLookup> Devices;
    }
}
