namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x45286EFF73305E1F, NameHash = 0xCEBA3C32BCAF04F6)]
    public class GcMissionSequenceWaitForStatSeasonal : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public NMSString0x10 Stat;
        [NMS(Index = 2)]
        /* 0x010 */ public NMSString0x10 StatGroup;
        [NMS(Index = 3)]
        /* 0x020 */ public int Amount;
        [NMS(Index = 6)]
        /* 0x024 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x0A4 */ public NMSString0x80 Message;
        [NMS(Index = 5)]
        /* 0x124 */ public bool EncouragesFighting;
        [NMS(Index = 4)]
        /* 0x125 */ public bool TakeAmountFromSeasonalData;
    }
}
