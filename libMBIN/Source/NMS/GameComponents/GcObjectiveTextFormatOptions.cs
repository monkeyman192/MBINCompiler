namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8722D32CBF096EE2, NameHash = 0xF124AA0E)]
    public class GcObjectiveTextFormatOptions : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A FormattableObjective;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x20A FormattableObjectiveTip;
        [NMS(Index = 0)]
        /* 0x40 */ public bool ObjectivesCanBeFormattedBySequences;
    }
}
