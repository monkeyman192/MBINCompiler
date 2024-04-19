namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E8C00C5C70AB479, NameHash = 0x49B1F2E8A11B19B6)]
    public class GcMissionSequenceProductAmountNeeded : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Item;
        /* 0x010 */ public NMSString0x10 ToBuild;
        /* 0x020 */ public NMSString0x80 DebugText;
        /* 0x0A0 */ public NMSString0x80 Message;
        /* 0x120 */ public bool IsRepair;
    }
}
