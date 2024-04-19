namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDE9730230B3623F0, NameHash = 0x43A40CA703B36FA8)]
    public class GcMissionSequenceEnsureBarrelsAtPlayerSettlement : NMSTemplate
    {
        /* 0x00 */ public int MinBarrelsThreshold;
        /* 0x04 */ public int NumBarrels;
        /* 0x08 */ public NMSString0x80 DebugText;
        /* 0x88 */ public NMSString0x80 Message;
    }
}
