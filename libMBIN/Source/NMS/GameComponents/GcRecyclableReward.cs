namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2C29E00ACCF0B2BB, NameHash = 0x2CBEB443)]
    public class GcRecyclableReward : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 RecycleEffectOverride;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 RewardID;
    }
}
