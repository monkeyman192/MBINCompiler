namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x39D37D294E47C3C4, NameHash = 0xED0B8631)]
    public class GcRewardSpecificSeasonalSubstance : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 2)]
        /* 0x10 */ public int AmountMax;
        [NMS(Index = 1)]
        /* 0x14 */ public int AmountMin;
        [NMS(Index = 3)]
        /* 0x18 */ public float ChanceToUse;
        [NMS(Index = 4)]
        /* 0x1C */ public int SeasonNumber;
    }
}
