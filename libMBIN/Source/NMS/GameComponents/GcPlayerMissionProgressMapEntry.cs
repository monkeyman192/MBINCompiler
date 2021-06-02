using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xE570F5A95882F6FD, NameHash = 0x7D5B5172D2A5F9E5)]
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