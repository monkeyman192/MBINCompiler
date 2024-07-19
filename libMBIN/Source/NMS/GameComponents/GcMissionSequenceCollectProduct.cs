using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2275BF4FEADD3A70, NameHash = 0xB22EB8F2)]
    public class GcMissionSequenceCollectProduct : NMSTemplate
    {
        [NMS(Index = 18)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 7)]
        /* 0x10 */ public NMSString0x10 ForBuild;
        [NMS(Index = 8)]
        /* 0x20 */ public NMSString0x10 ForRepair;
        [NMS(Index = 0)]
        /* 0x30 */ public VariableSizeString Message;
        [NMS(Index = 3)]
        /* 0x40 */ public NMSString0x10 Product;
        [NMS(Index = 5)]
        /* 0x50 */ public int AmountMax;
        [NMS(Index = 4)]
        /* 0x54 */ public int AmountMin;
        [NMS(Index = 1)]
        /* 0x58 */ public GcDefaultMissionProductEnum Default;
        [NMS(Index = 9)]
        /* 0x5C */ public GcItemNeedPurpose Purpose;
        [NMS(Index = 17)]
        /* 0x60 */ public bool CanFormatObjectives;
        [NMS(Index = 16)]
        /* 0x61 */ public bool CanSetIcon;
        [NMS(Index = 13)]
        /* 0x62 */ public bool DependentOnSeasonMilestone;
        [NMS(Index = 11)]
        /* 0x63 */ public bool FromNow;
        [NMS(Index = 14)]
        /* 0x64 */ public bool HintAtCraftTree;
        [NMS(Index = 15)]
        /* 0x65 */ public bool SearchCookingIngredients;
        [NMS(Index = 12)]
        /* 0x66 */ public bool TakeAmountFromSeasonData;
        [NMS(Index = 10)]
        /* 0x67 */ public bool TeachIfNotKnown;
        [NMS(Index = 2)]
        /* 0x68 */ public bool UseDefaultValue;
        [NMS(Index = 6)]
        /* 0x69 */ public bool WaitForSelected;
    }
}
