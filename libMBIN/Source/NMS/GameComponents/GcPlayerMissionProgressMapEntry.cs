using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPlayerMissionProgressMapEntry : NMSTemplate
    {
        public NMSString0x10 Mission;
        public int MinProgress;
        public int MaxProgress;
        public int NewProgress;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding1C;
    }
}
