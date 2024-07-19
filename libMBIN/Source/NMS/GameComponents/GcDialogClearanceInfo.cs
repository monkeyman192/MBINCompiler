namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFD19A5851643EE2D, NameHash = 0xF9B3B3C6)]
    public class GcDialogClearanceInfo : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A GlobalDialogID;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 AssociatedMission;
        [NMS(Index = 2)]
        /* 0x30 */ public bool AlwaysForceClearThisPair;
    }
}
