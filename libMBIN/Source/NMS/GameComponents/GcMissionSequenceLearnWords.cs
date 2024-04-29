namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x28039A6858BD451D, NameHash = 0x2A6B4FAF511D932F)]
    public class GcMissionSequenceLearnWords : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public int Amount;
        [NMS(Index = 2)]
        /* 0x04 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x84 */ public NMSString0x80 Message;
    }
}
