namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x140)]
    public class GcRefinerUnitComponentData : NMSTemplate
    {
        public GcMaintenanceComponentData MaintenanceData;
        public int NumInputs;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] EndPadding;
    }
}
