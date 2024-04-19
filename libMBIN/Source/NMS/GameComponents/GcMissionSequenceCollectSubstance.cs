using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x345E1430C561E466, NameHash = 0x84D6228673F661A6)]
    public class GcMissionSequenceCollectSubstance : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 ForBuild;
        /* 0x010 */ public NMSString0x10 ForRepair;
        /* 0x020 */ public NMSString0x10 Substance;
        /* 0x030 */ public int AmountMax;
        /* 0x034 */ public int AmountMin;
        /* 0x038 */ public GcDefaultMissionSubstanceEnum Default;
        /* 0x03C */ public float DefaultValueMultiplier;
        /* 0x040 */ public GcItemNeedPurpose Purpose;
        /* 0x044 */ public NMSString0x80 DebugText;
        /* 0x0C4 */ public NMSString0x80 Message;
        /* 0x144 */ public bool CanFormatObjectives;
        /* 0x145 */ public bool CanSetIcon;
        /* 0x146 */ public bool FromNow;
        /* 0x147 */ public bool SearchCookingIngredients;
        /* 0x148 */ public bool TakeAmountFromSeasonData;
        /* 0x149 */ public bool UseDefaultValue;
        /* 0x14A */ public bool WaitForSelected;
    }
}
