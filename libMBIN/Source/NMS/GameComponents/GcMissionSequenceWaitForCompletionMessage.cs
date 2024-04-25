namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEFB73DDC290CD191, NameHash = 0xA0F8CF4879F9AA03)]
    public class GcMissionSequenceWaitForCompletionMessage : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A MessageWhenInterstellar;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A ReturnToOptionalScanEvent;
        [NMS(Index = 3)]
        /* 0x40 */ public NMSString0x10 CompletionCost;
        [NMS(Index = 4)]
        /* 0x50 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0xD0 */ public NMSString0x80 Message;
    }
}
