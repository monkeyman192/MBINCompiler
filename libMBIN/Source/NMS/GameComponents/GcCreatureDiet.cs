using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xFB2F051D3A345062, NameHash = 0xEF306B43D1C79D7F)]
    public class GcCreatureDiet : NMSTemplate
    {
        public enum DietEnum { Carnivore, Omnivore, Herbivore }
        public DietEnum Diet;
    }
}
