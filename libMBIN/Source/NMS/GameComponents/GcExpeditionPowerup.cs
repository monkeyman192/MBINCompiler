using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0x8D71FA6CE0ED29EA, NameHash = 0xB76095BD04FCB5D2)]
    public class GcExpeditionPowerup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ProductId;
        public GcFrigateStatType StatModified;
        public int ChargeValue;
        [NMS(Size = 0x20)]
        public string SelectionDescription;
        [NMS(Size = 0x20)]
        public string ModuleDescription;
    }
}
