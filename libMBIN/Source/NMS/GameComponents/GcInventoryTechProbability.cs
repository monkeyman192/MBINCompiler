using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcInventoryTechProbability : NMSTemplate
    {
        public NMSString0x10 Tech;
        public int DesiredTechProbability;
        public string[] DesiredTechProbabilityValues()
        {
            return new[] { "Never", "Rare", "Common", "Always" };
        }
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
