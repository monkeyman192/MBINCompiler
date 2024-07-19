using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC299A90D1EC8CE20, NameHash = 0x9ED38E36)]
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
