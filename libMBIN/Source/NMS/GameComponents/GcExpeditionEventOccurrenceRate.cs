using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x64, GUID = 0x24812B86AFC66CF6)]
    public class GcExpeditionEventOccurrenceRate : NMSTemplate
    {
        [NMS( EnumType = typeof( GcExpeditionCategory.ExpeditionCategoryEnum ) )]
        public GcExpeditionDurationValues[] ExpeditionCategory;
    }
}
