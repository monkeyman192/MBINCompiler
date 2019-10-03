using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x250, GUID = 0xF81C3B236D24416E, NameHash = 0xD2A73F296D17A20)]
    public class GcRefinerUnitComponentData : NMSTemplate
    {
        public GcMaintenanceComponentData MaintenanceData;
        public int NumInputs;
        public bool IsCooker;
        [NMS(Size = 0xB, Ignore = true)]
        public byte[] EndPadding;
    }
}
