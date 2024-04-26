using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5D83CC274F0C9132, NameHash = 0xD0D744F61AB1E31B)]
    public class GcMissionSequenceCollectLocalSubstance : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public NMSString0x20A UseScanEventToDetermineLocation;
        [NMS(Index = 3)]
        /* 0x020 */ public int Amount;
        [NMS(Index = 5)]
        /* 0x024 */ public float DefaultValueMultiplier;
        [NMS(Index = 2)]
        /* 0x028 */ public GcLocalSubstanceType LocalSubstanceType;
        [NMS(Index = 11)]
        /* 0x02C */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x0AC */ public NMSString0x80 Message;
        [NMS(Index = 7)]
        /* 0x12C */ public bool CanFormatObjectives;
        [NMS(Index = 9)]
        /* 0x12D */ public bool CanSetIcon;
        [NMS(Index = 8)]
        /* 0x12E */ public bool FromNow;
        [NMS(Index = 10)]
        /* 0x12F */ public bool TakeAmountFromSeasonData;
        [NMS(Index = 4)]
        /* 0x130 */ public bool UseDefaultValue;
        [NMS(Index = 6)]
        /* 0x131 */ public bool WaitForSelected;
    }
}
