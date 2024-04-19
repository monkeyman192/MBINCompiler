using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA087799D6FDF7DFB, NameHash = 0x139E6194371FE10E)]
    public class GcMissionSequenceCollectProduct : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 ForBuild;
        /* 0x010 */ public NMSString0x10 ForRepair;
        /* 0x020 */ public NMSString0x10 Product;
        /* 0x030 */ public int AmountMax;
        /* 0x034 */ public int AmountMin;
        /* 0x038 */ public GcDefaultMissionProductEnum Default;
        /* 0x03C */ public GcItemNeedPurpose Purpose;
        /* 0x040 */ public NMSString0x80 DebugText;
        /* 0x0C0 */ public NMSString0x80 Message;
        /* 0x140 */ public bool CanFormatObjectives;
        /* 0x141 */ public bool CanSetIcon;
        /* 0x142 */ public bool DependentOnSeasonMilestone;
        /* 0x143 */ public bool FromNow;
        /* 0x144 */ public bool HintAtCraftTree;
        /* 0x145 */ public bool SearchCookingIngredients;
        /* 0x146 */ public bool TakeAmountFromSeasonData;
        /* 0x147 */ public bool TeachIfNotKnown;
        /* 0x148 */ public bool UseDefaultValue;
        /* 0x149 */ public bool WaitForSelected;
    }
}
