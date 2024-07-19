namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x96F79E9194CC6B99, NameHash = 0x291A6A7E)]
    public class GcRewardSecondarySubstance : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 1)]
        /* 0x10 */ public float AmountFactor;
        [NMS(Index = 2)]
        /* 0x14 */ public bool RewardAsBlobs;
    }
}
