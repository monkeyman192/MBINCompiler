namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x164C5791160C1C7D, NameHash = 0x904C594862FC894E)]
    public class GcRewardAssessCookedProduct : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public int AmountAverage;
        [NMS(Index = 1)]
        /* 0x04 */ public int AmountBad;
        [NMS(Index = 4)]
        /* 0x08 */ public int AmountBest;
        [NMS(Index = 5)]
        /* 0x0C */ public int AmountBestUpper;
        [NMS(Index = 3)]
        /* 0x10 */ public int AmountGood;
        [NMS(Index = 0)]
        /* 0x14 */ public int AmountWorst;
    }
}
