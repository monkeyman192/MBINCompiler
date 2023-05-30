using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcRealitySubstanceCraftingMix : NMSTemplate // 0x18 bytes
    {
        public NMSString0x10 ID;

        public int Ratio;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
