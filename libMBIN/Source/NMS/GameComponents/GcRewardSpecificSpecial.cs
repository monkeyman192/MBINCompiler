namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6C2D7F587206D875, NameHash = 0xCF9FC45A7B70BB85)]
    public class GcRewardSpecificSpecial : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A Message;
        [NMS(Index = 4)]
        /* 0x20 */ public NMSString0x20A MilestoneRewardOverrideText;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 ID;
        [NMS(Index = 5)]
        /* 0x50 */ public bool HideInSeasonRewards;
        [NMS(Index = 2)]
        /* 0x51 */ public bool ShowSpecialProductPopup;
        [NMS(Index = 3)]
        /* 0x52 */ public bool UseSpecialFormatting;
    }
}
