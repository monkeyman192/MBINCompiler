namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF59F20CCE22DC03C, NameHash = 0x6D88488E4483F056)]
    public class GcRewardProcTechProduct : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Group;
        /* 0x20 */ public int WeightedChanceEpic;
        /* 0x24 */ public int WeightedChanceLegendary;
        /* 0x28 */ public int WeightedChanceNormal;
        /* 0x2C */ public int WeightedChanceRare;
        /* 0x30 */ public bool ForceQualityRelevant;
        /* 0x31 */ public bool ForceRelevant;
    }
}
