namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE9EDF1DF8469B388, NameHash = 0x8830D7E)]
    public class GcMissionSequenceWaitForCompletionMessage : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A MessageWhenInterstellar;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A ReturnToOptionalScanEvent;
        [NMS(Index = 3)]
        /* 0x40 */ public NMSString0x10 CompletionCost;
        [NMS(Index = 4)]
        /* 0x50 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x60 */ public VariableSizeString Message;
    }
}
