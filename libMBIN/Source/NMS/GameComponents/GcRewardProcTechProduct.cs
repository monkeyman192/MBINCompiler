namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEF79674736E6D397, NameHash = 0xC2F84D8E)]
    public class GcRewardProcTechProduct : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Group;
        [NMS(Index = 3)]
        /* 0x20 */ public int WeightedChanceEpic;
        [NMS(Index = 4)]
        /* 0x24 */ public int WeightedChanceLegendary;
        [NMS(Index = 1)]
        /* 0x28 */ public int WeightedChanceNormal;
        [NMS(Index = 2)]
        /* 0x2C */ public int WeightedChanceRare;
        [NMS(Index = 6)]
        /* 0x30 */ public bool ForceQualityRelevant;
        [NMS(Index = 5)]
        /* 0x31 */ public bool ForceRelevant;
    }
}
