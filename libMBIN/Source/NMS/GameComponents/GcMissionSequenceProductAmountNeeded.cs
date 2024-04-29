namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDF7A4DF3A41CE5C8, NameHash = 0x49B1F2E8A11B19B6)]
    public class GcMissionSequenceProductAmountNeeded : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public NMSString0x10 Item;
        [NMS(Index = 2)]
        /* 0x010 */ public NMSString0x10 ToBuild;
        [NMS(Index = 4)]
        /* 0x020 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x0A0 */ public NMSString0x80 Message;
        [NMS(Index = 3)]
        /* 0x120 */ public bool IsRepair;
    }
}
