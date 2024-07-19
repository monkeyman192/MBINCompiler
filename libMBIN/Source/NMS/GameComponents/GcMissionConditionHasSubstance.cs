using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB74FE9D1C50BA68B, NameHash = 0xC1590FD1)]
    public class GcMissionConditionHasSubstance : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 Substance;
        [NMS(Index = 2)]
        /* 0x10 */ public int Amount;
        [NMS(Index = 0)]
        /* 0x14 */ public GcDefaultMissionSubstanceEnum Default;
        [NMS(Index = 4)]
        /* 0x18 */ public float DefaultValueMultiplier;
        [NMS(Index = 7)]
        /* 0x1C */ public GcItemNeedPurpose Purpose;
        [NMS(Index = 6)]
        /* 0x20 */ public bool MustBeImmediatelyAccessible;
        [NMS(Index = 5)]
        /* 0x21 */ public bool TakeAmountFromSeasonData;
        [NMS(Index = 3)]
        /* 0x22 */ public bool UseDefaultAmount;
    }
}
