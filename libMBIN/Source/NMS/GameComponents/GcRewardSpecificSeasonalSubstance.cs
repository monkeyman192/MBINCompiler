namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B80AD700CFA7BB9, NameHash = 0xD772C003DA86A5A1)]
    public class GcRewardSpecificSeasonalSubstance : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public int AmountMax;
        /* 0x14 */ public int AmountMin;
        /* 0x18 */ public float ChanceToUse;
        /* 0x1C */ public int SeasonNumber;
    }
}
