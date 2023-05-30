using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcBiomeListPerStarType : NMSTemplate
    {
        [NMS(Size = 4)]
        public GcBiomeList[] StarType;

        [NMS(Size = 4)]
        public float[] LifeChance;
    }
}
