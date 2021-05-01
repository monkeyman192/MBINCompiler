using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x64, GUID = 0x24812B86AFC66CF6, NameHash = 0x217B9012F2F7FC1F)]
    public class GcExpeditionEventOccurrenceRate : NMSTemplate
    {
        [NMS(Size = 0x5, EnumType = typeof(GcExpeditionCategory.ExpeditionCategoryEnum))]
        public CgExpeditionCategoryStrength[] ExpeditionCategory;
    }
}
