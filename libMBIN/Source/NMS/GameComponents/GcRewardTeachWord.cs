using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE7BAA18600D506BD, NameHash = 0xFE5851C36CE8242F)]
    public class GcRewardTeachWord : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public int AmountMax;
        [NMS(Index = 3)]
        /* 0x04 */ public int AmountMin;
        [NMS(Index = 2)]
        /* 0x08 */ public GcWordCategoryTableEnum Category;
        [NMS(Index = 0)]
        /* 0x0C */ public GcAlienRace Race;
        [NMS(Index = 1)]
        /* 0x10 */ public bool UseCategory;
    }
}
