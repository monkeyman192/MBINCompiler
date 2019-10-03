using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x14E7F177E598645, NameHash = 0xB387E3560FAA5681)]
    public class GcDamageMultiplier : NMSTemplate
    {
        public GcDamageType Type;
        public float Multiplier;
    }
}
