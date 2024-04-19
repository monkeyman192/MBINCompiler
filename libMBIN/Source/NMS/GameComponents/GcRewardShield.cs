namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x505557EF5A3779E9, NameHash = 0x55E2192D51D7971B)]
    public class GcRewardShield : NMSTemplate
    {
        /* 0x0 */ public int AmountMax;
        /* 0x4 */ public int AmountMin;
        /* 0x8 */ public bool ShowOSDOnFail;
        /* 0x9 */ public bool ShowOSDOnSuccess;
    }
}
