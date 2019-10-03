using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA18791E073723FD, NameHash = 0xA420A86F131CF88)]
    public class GcMissionConditionPercentageChance : NMSTemplate
    {
        public int Percent;
        public bool Seeded;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
