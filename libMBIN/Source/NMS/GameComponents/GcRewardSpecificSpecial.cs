namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC55ED908F1C87E63, NameHash = 0x86FC4B92)]
    public class GcRewardSpecificSpecial : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A Message;
        [NMS(Index = 4)]
        /* 0x20 */ public NMSString0x20A MilestoneRewardOverrideText;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 ID;
        [NMS(Index = 6)]
        /* 0x50 */ public bool FailIfAlreadyKnown;
        [NMS(Index = 5)]
        /* 0x51 */ public bool HideInSeasonRewards;
        [NMS(Index = 2)]
        /* 0x52 */ public bool ShowSpecialProductPopup;
        [NMS(Index = 3)]
        /* 0x53 */ public bool UseSpecialFormatting;
    }
}
