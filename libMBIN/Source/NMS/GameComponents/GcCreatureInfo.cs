using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcCreatureInfo : NMSTemplate
    {
        public int Age;
        public string[] AgeValues()
        {
            return new[] { "Regular", "Weird" };
        }

        public NMSString0x80 Gender1;
        public NMSString0x80 Gender2;
        public NMSString0x80 Temperament;
        public NMSString0x80 Diet;
        public NMSString0x80 Weight1;
        public NMSString0x80 Height1;
        public NMSString0x80 Weight2;
        public NMSString0x80 Height2;

        public float Weight1Float;
        public float Height1Float;
        public float Weight2Float;
        public float Height2Float;

        public GcRarity Rarity;
    }
}
