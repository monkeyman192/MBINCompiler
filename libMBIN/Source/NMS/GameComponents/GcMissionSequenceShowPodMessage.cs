namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCCEEABB4A415DC38, NameHash = 0xA3940C8D106BB96E)]
    public class GcMissionSequenceShowPodMessage : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x80 */ public NMSString0x80 Message;
    }
}
