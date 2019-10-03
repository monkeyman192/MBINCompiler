using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8707DA4682020EC8, NameHash = 0xF0E840DA05227000)]
    public class GcCreatureGroupProbability : NMSTemplate       // size: 0x18
    {
        [NMS(Size = 0x10)]
        public string Group;
        public float Probability;         // 3F800000h
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
