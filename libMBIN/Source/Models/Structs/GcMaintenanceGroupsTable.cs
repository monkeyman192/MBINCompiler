namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x70)]
    public class GcMaintenanceGroupsTable : NMSTemplate
    {
        [NMS(Size = 0x7, EnumValue = new string[7] { "Custom", "Farming", "Fuelling", "Repairing", "EasyRepairing", "Cleaning", "Frigate" })]
        public GcMaintenanceGroup[] Groups;
    }
}
