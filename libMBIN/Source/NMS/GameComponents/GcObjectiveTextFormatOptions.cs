namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x49DC6D819EDE244D, NameHash = 0x2B3787F904F75390)]
    public class GcObjectiveTextFormatOptions : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A FormattableObjective;
        /* 0x20 */ public NMSString0x20A FormattableObjectiveTip;
        /* 0x40 */ public bool ObjectivesCanBeFormattedBySequences;
    }
}
