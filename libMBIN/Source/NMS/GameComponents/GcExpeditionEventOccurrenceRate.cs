using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF7A2340526593A46, NameHash = 0x7B6C44AE)]
    public class GcExpeditionEventOccurrenceRate : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcExpeditionCategory.ExpeditionCategoryEnum))]
        /* 0x0 */ public GcExpeditionCategoryStrength[] ExpeditionCategory;
    }
}
