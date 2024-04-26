using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x37F80B4F24A556F4, NameHash = 0x9BF04097261BBFEA)]
    public class TkOpenVRControllerList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkOpenVRControllerLookup> Devices;
    }
}
