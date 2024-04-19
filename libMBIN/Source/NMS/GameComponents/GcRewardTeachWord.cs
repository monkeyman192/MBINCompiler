using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF5F66A4C2051609, NameHash = 0xFE5851C36CE8242F)]
    public class GcRewardTeachWord : NMSTemplate
    {
        /* 0x00 */ public int AmountMax;
        /* 0x04 */ public int AmountMin;
        /* 0x08 */ public GcWordCategoryTableEnum Category;
        /* 0x0C */ public GcAlienRace Race;
        /* 0x10 */ public bool UseCategory;
    }
}
