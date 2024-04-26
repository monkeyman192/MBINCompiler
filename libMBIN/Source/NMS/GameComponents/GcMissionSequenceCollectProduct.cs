using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA087799D6FDF7DFB, NameHash = 0x139E6194371FE10E)]
    public class GcMissionSequenceCollectProduct : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x000 */ public NMSString0x10 ForBuild;
        [NMS(Index = 8)]
        /* 0x010 */ public NMSString0x10 ForRepair;
        [NMS(Index = 3)]
        /* 0x020 */ public NMSString0x10 Product;
        [NMS(Index = 5)]
        /* 0x030 */ public int AmountMax;
        [NMS(Index = 4)]
        /* 0x034 */ public int AmountMin;
        [NMS(Index = 1)]
        /* 0x038 */ public GcDefaultMissionProductEnum Default;
        [NMS(Index = 9)]
        /* 0x03C */ public GcItemNeedPurpose Purpose;
        [NMS(Index = 18)]
        /* 0x040 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x0C0 */ public NMSString0x80 Message;
        [NMS(Index = 17)]
        /* 0x140 */ public bool CanFormatObjectives;
        [NMS(Index = 16)]
        /* 0x141 */ public bool CanSetIcon;
        [NMS(Index = 13)]
        /* 0x142 */ public bool DependentOnSeasonMilestone;
        [NMS(Index = 11)]
        /* 0x143 */ public bool FromNow;
        [NMS(Index = 14)]
        /* 0x144 */ public bool HintAtCraftTree;
        [NMS(Index = 15)]
        /* 0x145 */ public bool SearchCookingIngredients;
        [NMS(Index = 12)]
        /* 0x146 */ public bool TakeAmountFromSeasonData;
        [NMS(Index = 10)]
        /* 0x147 */ public bool TeachIfNotKnown;
        [NMS(Index = 2)]
        /* 0x148 */ public bool UseDefaultValue;
        [NMS(Index = 6)]
        /* 0x149 */ public bool WaitForSelected;
    }
}
