using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDC9DA4C51D20A130, NameHash = 0x6D88488E4483F056)]
    public class GcRewardProcTechProduct : NMSTemplate
    {
        public NMSString0x20A Group;
        public int WeightedChanceNormal;
        public int WeightedChanceRare;
        public int WeightedChanceEpic;
        public int WeightedChanceLegendary;
        public bool ForceRelevant;
        public bool ForceQualityRelevant;
    }
}
