using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3613A42A357A3D5B, NameHash = 0x217B9012F2F7FC1F)]
    public class GcExpeditionEventOccurrenceRate : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcExpeditionCategory.ExpeditionCategoryEnum))]
        /* 0x0 */ public GcExpeditionCategoryStrength[] ExpeditionCategory;
    }
}
