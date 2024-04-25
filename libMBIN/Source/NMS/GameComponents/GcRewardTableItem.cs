namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA408C1BC4EB7A0BD, NameHash = 0x743B54DBF617C58D)]
    public class GcRewardTableItem : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSTemplate Reward;
        [NMS(Index = 0)]
        /* 0x50 */ public float PercentageChance;
        [NMS(Index = 1)]
        /* 0x54 */ public NMSString0x40 LabelID;
    }
}
