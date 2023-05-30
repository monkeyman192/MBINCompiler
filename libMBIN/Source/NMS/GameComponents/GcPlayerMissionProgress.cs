using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPlayerMissionProgress : NMSTemplate // 0x18 bytes
    {
        public NMSString0x10 Mission;
        public int Progress;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
