using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x20692F37FD2BADBE, NameHash = 0x9D5EE4FB6274CF9E)]
    public class GcMissionConditionHasSubstance : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Substance;
        /* 0x10 */ public int Amount;
        /* 0x14 */ public GcDefaultMissionSubstanceEnum Default;
        /* 0x18 */ public float DefaultValueMultiplier;
        /* 0x1C */ public GcItemNeedPurpose Purpose;
        /* 0x20 */ public bool MustBeImmediatelyAccessible;
        /* 0x21 */ public bool TakeAmountFromSeasonData;
        /* 0x22 */ public bool UseDefaultAmount;
    }
}
