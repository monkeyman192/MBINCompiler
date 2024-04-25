namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x540F8CE488026251, NameHash = 0xD0AAAD197E826825)]
    public class GcRewardSpecificProductRecipe : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A SeasonRewardFormat;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 ID;
        [NMS(Index = 2)]
        /* 0x30 */ public bool HideInSeasonRewards;
        [NMS(Index = 1)]
        /* 0x31 */ public bool Silent;
    }
}
