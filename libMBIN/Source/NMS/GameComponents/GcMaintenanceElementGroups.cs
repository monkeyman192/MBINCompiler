using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC73DD3B92E35C5CE, NameHash = 0x38F9072E9DC5078A)]
    public class GcMaintenanceElementGroups : NMSTemplate
    {
		public enum MaintenanceGroupEnum { Custom, Farming, Fuelling, Repairing, Cleaning }
		public MaintenanceGroupEnum MaintenanceGroup;
    }
}
