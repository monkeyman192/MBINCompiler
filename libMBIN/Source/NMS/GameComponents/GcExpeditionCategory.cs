using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x88175D4FD88CF82D, NameHash = 0x4F6C65318BF17139)]
    public class GcExpeditionCategory : NMSTemplate
    {
		public enum ExpeditionCategoryEnum { Combat, Exploration, Mining, Diplomacy, Balanced }
		public ExpeditionCategoryEnum ExpeditionCategory;
    }
}
