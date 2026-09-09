namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA680DD6339C270B, NameHash = 0x3DA8255E)]
    public class GcCostJourneyStatLevel : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 StatName;
        [NMS(Index = 1)]
        /* 0x10 */ public int RequiredLevel;
    }
}
