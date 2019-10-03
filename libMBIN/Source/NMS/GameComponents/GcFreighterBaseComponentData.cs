using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x1C784EA9C0D6B06B, NameHash = 0x8201F7ADD0F5959D)]
    public class GcFreighterBaseComponentData : NMSTemplate
    {
        [NMS(Size = 0x4)]
        public GcFreighterBaseOptions[] FreighterBaseOptions;
    }
}
