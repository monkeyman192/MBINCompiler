using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA54BD82E7B3A463D, NameHash = 0xD772C003DA86A5A1)]
    public class GcRewardSpecificSeasonalSubstance : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public int AmountMin;
        /* 0x14 */ public int AmountMax;
        /* 0x18 */ public float ChanceToUse;
        /* 0x1C */ public int SeasonNumbers;
    }
}
