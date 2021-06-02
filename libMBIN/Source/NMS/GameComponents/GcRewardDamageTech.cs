using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x9237693DE39BCF88, NameHash = 0x7DA0241C104EEDF)]
    public class GcRewardDamageTech : NMSTemplate
    {
        public GcTechnologyCategory Category;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Paddding4;
        public NMSString0x10 TechToDamage_optional;
        public bool ShowDamageMessage;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
