namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x44AA16D96DC948F6, NameHash = 0x15BC2878FF0C535)]
    public class GcMissionSequenceWaitForBuild : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 TargetTech;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x90 */ public NMSString0x80 Message;
    }
}
