namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFAD831A8B2051585, NameHash = 0x27D825D3)]
    public class GcMissionConditionBasePowerGenerated : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int Amount;
        [NMS(Index = 1)]
        /* 0x4 */ public bool MustBeSpare;
        [NMS(Index = 2)]
        /* 0x5 */ public bool TakeAmountFromSeasonData;
    }
}
