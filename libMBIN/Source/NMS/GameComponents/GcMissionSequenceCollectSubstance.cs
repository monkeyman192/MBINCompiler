using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x345E1430C561E466, NameHash = 0x84D6228673F661A6)]
    public class GcMissionSequenceCollectSubstance : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x000 */ public NMSString0x10 ForBuild;
        [NMS(Index = 11)]
        /* 0x010 */ public NMSString0x10 ForRepair;
        [NMS(Index = 4)]
        /* 0x020 */ public NMSString0x10 Substance;
        [NMS(Index = 6)]
        /* 0x030 */ public int AmountMax;
        [NMS(Index = 5)]
        /* 0x034 */ public int AmountMin;
        [NMS(Index = 1)]
        /* 0x038 */ public GcDefaultMissionSubstanceEnum Default;
        [NMS(Index = 3)]
        /* 0x03C */ public float DefaultValueMultiplier;
        [NMS(Index = 12)]
        /* 0x040 */ public GcItemNeedPurpose Purpose;
        [NMS(Index = 16)]
        /* 0x044 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x0C4 */ public NMSString0x80 Message;
        [NMS(Index = 9)]
        /* 0x144 */ public bool CanFormatObjectives;
        [NMS(Index = 8)]
        /* 0x145 */ public bool CanSetIcon;
        [NMS(Index = 13)]
        /* 0x146 */ public bool FromNow;
        [NMS(Index = 15)]
        /* 0x147 */ public bool SearchCookingIngredients;
        [NMS(Index = 14)]
        /* 0x148 */ public bool TakeAmountFromSeasonData;
        [NMS(Index = 2)]
        /* 0x149 */ public bool UseDefaultValue;
        [NMS(Index = 7)]
        /* 0x14A */ public bool WaitForSelected;
    }
}
