using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x36AF5A52111B9349, NameHash = 0x928E5193D2096007)]
    public class GcMissionConditionWristMenuOpen : NMSTemplate
    {
        public bool LeftHandOnly;
        public bool QuickMenuOnly;
        public bool GunHandOnly;
        public bool InventoryOnly;
    }
}
