namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x505557EF5A3779E9, NameHash = 0x55E2192D51D7971B)]
    public class GcRewardShield : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int AmountMax;
        [NMS(Index = 0)]
        /* 0x4 */ public int AmountMin;
        [NMS(Index = 3)]
        /* 0x8 */ public bool ShowOSDOnFail;
        [NMS(Index = 2)]
        /* 0x9 */ public bool ShowOSDOnSuccess;
    }
}
