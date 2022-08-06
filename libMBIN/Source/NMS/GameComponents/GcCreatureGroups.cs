using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4BCB512A8DC618E2, NameHash = 0xDC6AC60910C16B2D)]
    public class GcCreatureGroups : NMSTemplate
    {
		public enum CreatureGroupEnum { Solo, Couple, Group, Herd }
		public CreatureGroupEnum CreatureGroup;
    }
}