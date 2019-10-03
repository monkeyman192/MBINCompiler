using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x70, GUID = 0x97896CCD6D37AF95, NameHash = 0x4819F209285AD45B)]
    public class GcMaintenanceGroupsTable : NMSTemplate
    {
        public enum GroupEnum { Custom, Farming, Fuelling, Repairing, EasyRepairing, Cleaning, Frigate }
        [NMS(Size = 0x7, EnumType = typeof(GroupEnum))]
        public GcMaintenanceGroup[] Groups;
    }
}
