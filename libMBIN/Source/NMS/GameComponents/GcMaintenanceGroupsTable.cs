using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE92A459FC7521AE8, NameHash = 0xC7F6A4F5)]
    public class GcMaintenanceGroupsTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xA, EnumType = typeof(GcMaintenanceElementGroups.MaintenanceGroupEnum))]
        /* 0x0 */ public GcMaintenanceGroup[] Groups;
    }
}
