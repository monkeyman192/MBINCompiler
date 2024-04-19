using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5D83CC274F0C9132, NameHash = 0xD0D744F61AB1E31B)]
    public class GcMissionSequenceCollectLocalSubstance : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A UseScanEventToDetermineLocation;
        /* 0x020 */ public int Amount;
        /* 0x024 */ public float DefaultValueMultiplier;
        /* 0x028 */ public GcLocalSubstanceType LocalSubstanceType;
        /* 0x02C */ public NMSString0x80 DebugText;
        /* 0x0AC */ public NMSString0x80 Message;
        /* 0x12C */ public bool CanFormatObjectives;
        /* 0x12D */ public bool CanSetIcon;
        /* 0x12E */ public bool FromNow;
        /* 0x12F */ public bool TakeAmountFromSeasonData;
        /* 0x130 */ public bool UseDefaultValue;
        /* 0x131 */ public bool WaitForSelected;
    }
}
