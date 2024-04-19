using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD087AE3B999D1DF, NameHash = 0x9537448E73030512)]
    public class GcMissionConditionHasProduct : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Product;
        /* 0x10 */ public NMSString0x10 UseAmountToAffordRecipe;
        /* 0x20 */ public int Amount;
        /* 0x24 */ public GcDefaultMissionProductEnum Default;
        /* 0x28 */ public GcItemNeedPurpose Purpose;
        /* 0x2C */ public bool AllowedToSetInventoryHint;
        /* 0x2D */ public bool DependentOnSeasonMilestone;
        /* 0x2E */ public bool DoNotFormatText;
        /* 0x2F */ public bool ForceInventoryHintAtAllTimes;
        /* 0x30 */ public bool ForceSearchFreighterAndChests;
        /* 0x31 */ public bool MustBeImmediatelyAccessible;
        /* 0x32 */ public bool SearchCookingIngredients;
        /* 0x33 */ public bool SearchEveryShip;
        /* 0x34 */ public bool SearchGrave;
        /* 0x35 */ public bool SyncWithMissionFireteam;
        /* 0x36 */ public bool TakeAffordRecipeFromSeasonData;
        /* 0x37 */ public bool TakeAmountFromSeasonData;
        /* 0x38 */ public bool TakeIdFromSeasonData;
        /* 0x39 */ public bool UseAffordRecipeForTextFormatting;
        /* 0x3A */ public bool UseDefaultAmount;
        /* 0x3B */ public bool UseProductIconAsMissionIcon;
    }
}
