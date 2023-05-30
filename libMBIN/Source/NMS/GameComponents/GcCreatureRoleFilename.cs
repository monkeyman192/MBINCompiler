using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcCreatureRoleFilename : NMSTemplate // 0x90 bytes
    {
        public NMSString0x80 File;

        [NMS(Size = 4, EnumValue = new[] { "Dead", "Low", "Mid", "Full" })]
        public float[] BiomeProbability;
    }
}
