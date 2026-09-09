using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC5F25DF13527CB54, NameHash = 0xA8AB621D)]
    public class GcRewardCorvetteProduct : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public int AmountMax;
        [NMS(Index = 1)]
        /* 0x4 */ public int AmountMin;
        [NMS(Index = 0)]
        /* 0x8 */ public GcCorvettePartCategory EligibleCategories;
        [NMS(Index = 3)]
        /* 0xC */ public bool ForceSpecialMessage;
    }
}
