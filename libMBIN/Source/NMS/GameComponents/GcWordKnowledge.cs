using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcWordKnowledge : NMSTemplate // 0x18
    {
        public NMSString0x10 Word;

        [NMS(Size = 6)]
        public bool[] Races;

        [NMS(Size = 2, Ignore = true)]
        public byte[] Padding16;
    }
}
