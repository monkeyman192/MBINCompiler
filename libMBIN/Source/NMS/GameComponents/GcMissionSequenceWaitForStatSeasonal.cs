namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7AF7D1782CC7092D, NameHash = 0xCEBA3C32BCAF04F6)]
    public class GcMissionSequenceWaitForStatSeasonal : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Stat;
        /* 0x010 */ public NMSString0x10 StatGroup;
        /* 0x020 */ public int Amount;
        /* 0x024 */ public NMSString0x80 DebugText;
        /* 0x0A4 */ public NMSString0x80 Message;
        /* 0x124 */ public bool EncouragesFighting;
        /* 0x125 */ public bool TakeAmountFromSeasonalData;
    }
}
