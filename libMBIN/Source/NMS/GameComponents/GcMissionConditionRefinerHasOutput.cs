namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x96C4D8EC4EBA0B1F, NameHash = 0x7A9148E7)]
    public class GcMissionConditionRefinerHasOutput : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 OutputProduct;
        [NMS(Index = 1)]
        /* 0x10 */ public int OutputAmount;
        [NMS(Index = 3)]
        /* 0x14 */ public bool MustBeCooker;
        [NMS(Index = 2)]
        /* 0x15 */ public bool UseDefaultAmount;
    }
}
