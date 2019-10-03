using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x3D2192311E42199C, NameHash = 0x9BF04097261BBFEA)]
    public class TkOpenVRControllerList : NMSTemplate
    {
        public List<TkOpenVRControllerLookup> Devices;
    }
}
