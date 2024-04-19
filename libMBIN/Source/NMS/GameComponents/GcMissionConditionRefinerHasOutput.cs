namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x82D81B749F5372, NameHash = 0x6597D4E975E02DA7)]
    public class GcMissionConditionRefinerHasOutput : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 OutputProduct;
        /* 0x10 */ public int OutputAmount;
        /* 0x14 */ public bool MustBeCooker;
        /* 0x15 */ public bool UseDefaultAmount;
    }
}
