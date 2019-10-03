using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB63480FB49EE4C3C, NameHash = 0x989F3C45C63EA6B8)]
    public class GcMaintenanceGroup : NMSTemplate
    {
        public List<GcMaintenanceGroupEntry> Table;
    }
}
