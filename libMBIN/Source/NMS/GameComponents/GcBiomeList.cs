using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcBiomeList : NMSTemplate
    {
        [NMS(Size = 9)]
        public float[] BiomeProbability;
    }
}
