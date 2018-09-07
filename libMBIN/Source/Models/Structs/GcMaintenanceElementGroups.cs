using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcMaintenanceElementGroups : NMSTemplate
    {
		public enum MaintenanceGroupEnum { Custom, Farming, Fuelling, Repairing, Cleaning }
		public MaintenanceGroupEnum MaintenanceGroup;
    }
}
