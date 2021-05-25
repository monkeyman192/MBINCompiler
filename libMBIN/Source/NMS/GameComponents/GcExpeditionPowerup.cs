using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0xF42149E3C1B01929, NameHash = 0xB76095BD04FCB5D2)]
    public class GcExpeditionPowerup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ProductId;
        public GcFrigateStatType StatModified;
        public int ValueChange;
        [NMS(Size = 0x20)]
        public string SelectionDescription;
        [NMS(Size = 0x20)]
        public string ModuleDescription;
    }
}
