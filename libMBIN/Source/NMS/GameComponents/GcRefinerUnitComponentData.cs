using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x753DA7EC326F5429, NameHash = 0xD2A73F296D17A20)]
    public class GcRefinerUnitComponentData : NMSTemplate
    {
        public GcMaintenanceComponentData MaintenanceData;
        public int NumInputs;
        public bool IsCooker;
    }
}
