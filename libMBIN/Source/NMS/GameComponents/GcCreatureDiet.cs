using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x9718AB53D13CDD7F, NameHash = 0xEF306B43D1C79D7F)]
    public class GcCreatureDiet : NMSTemplate
    {
        // size: 0x4
        public enum DietEnum { Carnivore, Omnivore, Herbivore, Robot }
        public DietEnum Diet;
    }
}