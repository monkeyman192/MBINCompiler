namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x73C2BE56FB67E127, NameHash = 0xEFF2B2BC)]
    public class GcMissionSequenceWaitForStatSeasonal : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 Stat;
        [NMS(Index = 2)]
        /* 0x30 */ public NMSString0x10 StatGroup;
        [NMS(Index = 3)]
        /* 0x40 */ public int Amount;
        [NMS(Index = 5)]
        /* 0x44 */ public bool EncouragesFighting;
        [NMS(Index = 4)]
        /* 0x45 */ public bool TakeAmountFromSeasonalData;
    }
}
