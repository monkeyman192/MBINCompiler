using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB68608AB166884DF, NameHash = 0x55F0CA28)]
    public class GcMissionSequenceCollectSubstance : NMSTemplate
    {
        [NMS(Index = 16)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 10)]
        /* 0x10 */ public NMSString0x10 ForBuild;
        [NMS(Index = 11)]
        /* 0x20 */ public NMSString0x10 ForRepair;
        [NMS(Index = 0)]
        /* 0x30 */ public VariableSizeString Message;
        [NMS(Index = 4)]
        /* 0x40 */ public NMSString0x10 Substance;
        [NMS(Index = 6)]
        /* 0x50 */ public int AmountMax;
        [NMS(Index = 5)]
        /* 0x54 */ public int AmountMin;
        [NMS(Index = 1)]
        /* 0x58 */ public GcDefaultMissionSubstanceEnum Default;
        [NMS(Index = 3)]
        /* 0x5C */ public float DefaultValueMultiplier;
        [NMS(Index = 12)]
        /* 0x60 */ public GcItemNeedPurpose Purpose;
        [NMS(Index = 9)]
        /* 0x64 */ public bool CanFormatObjectives;
        [NMS(Index = 8)]
        /* 0x65 */ public bool CanSetIcon;
        [NMS(Index = 13)]
        /* 0x66 */ public bool FromNow;
        [NMS(Index = 15)]
        /* 0x67 */ public bool SearchCookingIngredients;
        [NMS(Index = 14)]
        /* 0x68 */ public bool TakeAmountFromSeasonData;
        [NMS(Index = 2)]
        /* 0x69 */ public bool UseDefaultValue;
        [NMS(Index = 7)]
        /* 0x6A */ public bool WaitForSelected;
    }
}
