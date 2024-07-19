namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF4B2F5C85F2E735E, NameHash = 0x3DA8255E)]
    public class GcCostJourneyStatLevel : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 StatName;
        [NMS(Index = 1)]
        /* 0x10 */ public int RequiredLevel;
    }
}
