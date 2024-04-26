namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x957D0B90903AE97, NameHash = 0x271F1C7199403F55)]
    public class GcMissionSequenceFeed : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public int AmountMax;
        [NMS(Index = 2)]
        /* 0x004 */ public int AmountMin;
        [NMS(Index = 4)]
        /* 0x008 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x088 */ public NMSString0x80 Message;
        [NMS(Index = 1)]
        /* 0x108 */ public bool RequireSpecificBait;
    }
}
