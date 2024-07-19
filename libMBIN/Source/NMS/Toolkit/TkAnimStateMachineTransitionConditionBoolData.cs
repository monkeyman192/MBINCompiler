namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4EBFDF3E010688B7, NameHash = 0x922CCC21)]
    public class TkAnimStateMachineTransitionConditionBoolData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Parameter;
        [NMS(Index = 1)]
        /* 0x10 */ public bool CompareValue;
    }
}
