using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x95FDC0BA86D6804, NameHash = 0x4819F209285AD45B)]
    public class GcMaintenanceGroupsTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xA, EnumType = typeof(GcMaintenanceElementGroups.MaintenanceGroupEnum))]
        /* 0x0 */ public GcMaintenanceGroup[] Groups;
    }
}
