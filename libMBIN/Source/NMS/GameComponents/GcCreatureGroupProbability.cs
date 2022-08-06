using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8707DA4682020EC8, NameHash = 0xF0E840DA05227000)]
    public class GcCreatureGroupProbability : NMSTemplate
    {
        public NMSString0x10 Group;
        public float Probability;         // 3F800000h
    }
}