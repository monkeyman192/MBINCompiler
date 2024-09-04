using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x814EB4EF2E7111E6, NameHash = 0xDB330A9F)]
    public class GcMissionConditionHasProduct : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 Product;
        [NMS(Index = 13)]
        /* 0x10 */ public NMSString0x10 UseAmountToAffordRecipe;
        [NMS(Index = 2)]
        /* 0x20 */ public int Amount;
        [NMS(Index = 0)]
        /* 0x24 */ public GcDefaultMissionProductEnum Default;
        [NMS(Index = 22)]
        /* 0x28 */ public GcProductCategory ProductCategory;
        [NMS(Index = 16)]
        /* 0x2C */ public GcItemNeedPurpose Purpose;
        [NMS(Index = 17)]
        /* 0x30 */ public bool AllowedToSetInventoryHint;
        [NMS(Index = 12)]
        /* 0x31 */ public bool DependentOnSeasonMilestone;
        [NMS(Index = 20)]
        /* 0x32 */ public bool DoNotFormatText;
        [NMS(Index = 18)]
        /* 0x33 */ public bool ForceInventoryHintAtAllTimes;
        [NMS(Index = 6)]
        /* 0x34 */ public bool ForceSearchFreighterAndChests;
        [NMS(Index = 5)]
        /* 0x35 */ public bool MustBeImmediatelyAccessible;
        [NMS(Index = 9)]
        /* 0x36 */ public bool SearchCookingIngredients;
        [NMS(Index = 7)]
        /* 0x37 */ public bool SearchEveryShip;
        [NMS(Index = 8)]
        /* 0x38 */ public bool SearchGrave;
        [NMS(Index = 4)]
        /* 0x39 */ public bool SyncWithMissionFireteam;
        [NMS(Index = 14)]
        /* 0x3A */ public bool TakeAffordRecipeFromSeasonData;
        [NMS(Index = 10)]
        /* 0x3B */ public bool TakeAmountFromSeasonData;
        [NMS(Index = 11)]
        /* 0x3C */ public bool TakeIdFromSeasonData;
        [NMS(Index = 15)]
        /* 0x3D */ public bool UseAffordRecipeForTextFormatting;
        [NMS(Index = 3)]
        /* 0x3E */ public bool UseDefaultAmount;
        [NMS(Index = 21)]
        /* 0x3F */ public bool UseProductCategory;
        [NMS(Index = 19)]
        /* 0x40 */ public bool UseProductIconAsMissionIcon;
    }
}
