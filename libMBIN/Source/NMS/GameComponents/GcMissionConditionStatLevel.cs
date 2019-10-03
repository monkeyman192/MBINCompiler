using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x2BC80C07487546FC, NameHash = 0xA56864A865FEBE6D)]
    public class GcMissionConditionStatLevel : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Stat;
        [NMS(Size = 0x10)]
        public string StatGroup;
        public int Level;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding2C;
        [NMS(Size = 0x10)]
        public string CompareStat;
        public int DisplayMilestoneNumber;
        public TkEqualityEnum Test;
    }
}
