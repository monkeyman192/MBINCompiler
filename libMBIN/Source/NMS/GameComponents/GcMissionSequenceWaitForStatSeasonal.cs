namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6534E04476495BD3, NameHash = 0xEFF2B2BC)]
    public class GcMissionSequenceWaitForStatSeasonal : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 Stat;
        [NMS(Index = 2)]
        /* 0x30 */ public NMSString0x10 StatGroup;
        [NMS(Index = 3)]
        /* 0x40 */ public int Amount;
        [NMS(Index = 6)]
        /* 0x44 */ public bool EncouragesFighting;
        [NMS(Index = 5)]
        /* 0x45 */ public bool TakeAmountFromMissionStat;
        [NMS(Index = 4)]
        /* 0x46 */ public bool TakeAmountFromSeasonalData;
    }
}
