namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7A03DF972A353920, NameHash = 0x97DBB6FC681295D3)]
    public class GcDialogClearanceInfo : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A GlobalDialogID;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 AssociatedMission;
    }
}
