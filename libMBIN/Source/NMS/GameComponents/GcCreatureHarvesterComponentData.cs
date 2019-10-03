using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x250, GUID = 0x35761789EB98ACE, NameHash = 0x5B935AA89717BCC4)]
    public class GcCreatureHarvesterComponentData : NMSTemplate
    {
        public GcMaintenanceComponentData MaintenanceData;
        public int NumSlots;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] EndPadding;
    }
}
