namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x84148783106D2CB8, NameHash = 0x79D85DCF556B9E6B)]
    public class GcMissionSequenceWaitForDepots : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public int AmountMax;
        [NMS(Index = 1)]
        /* 0x04 */ public int AmountMin;
        [NMS(Index = 3)]
        /* 0x08 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x88 */ public NMSString0x80 Message;
    }
}
