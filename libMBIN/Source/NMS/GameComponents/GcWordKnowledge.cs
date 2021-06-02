using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xB3617F01FF3C2D0D, NameHash = 0x30324FBB2A97B16E)]
    public class GcWordKnowledge : NMSTemplate // 0x18
    {
        public NMSString0x10 Word;

        [NMS(Size = 6)]
        public bool[] Races;

        [NMS(Size = 2, Ignore = true)]
        public byte[] Padding16;
    }
}