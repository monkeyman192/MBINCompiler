using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9237693DE39BCF88, NameHash = 0x7DA0241C104EEDF)]
    public class GcRewardDamageTech : NMSTemplate
    {
        public GcTechnologyCategory Category;
        public NMSString0x10 TechToDamage_optional;
        public bool ShowDamageMessage;
    }
}
