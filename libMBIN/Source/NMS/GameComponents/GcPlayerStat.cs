using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPlayerStat : NMSTemplate // 0x20 bytes
    {
        public NMSString0x10 Id;

        public GcStatValueData Value;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding1C;
    }
}
