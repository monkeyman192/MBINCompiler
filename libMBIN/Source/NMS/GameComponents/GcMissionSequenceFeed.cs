namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x957D0B90903AE97, NameHash = 0x271F1C7199403F55)]
    public class GcMissionSequenceFeed : NMSTemplate
    {
        /* 0x000 */ public int AmountMax;
        /* 0x004 */ public int AmountMin;
        /* 0x008 */ public NMSString0x80 DebugText;
        /* 0x088 */ public NMSString0x80 Message;
        /* 0x108 */ public bool RequireSpecificBait;
    }
}
