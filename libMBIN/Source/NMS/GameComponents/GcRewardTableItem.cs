namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x19C082A7BAFCE501, NameHash = 0xCEEDBB60)]
    public class GcRewardTableItem : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString LabelID;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSTemplate Reward;
        [NMS(Index = 0)]
        /* 0x20 */ public float PercentageChance;
    }
}
