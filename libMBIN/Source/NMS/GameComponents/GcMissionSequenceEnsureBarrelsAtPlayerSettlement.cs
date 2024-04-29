namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5F6938C030D12841, NameHash = 0x43A40CA703B36FA8)]
    public class GcMissionSequenceEnsureBarrelsAtPlayerSettlement : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public int MinBarrelsThreshold;
        [NMS(Index = 1)]
        /* 0x04 */ public int NumBarrels;
        [NMS(Index = 3)]
        /* 0x08 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x88 */ public NMSString0x80 Message;
    }
}
