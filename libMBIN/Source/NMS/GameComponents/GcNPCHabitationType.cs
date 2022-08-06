using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4C36609963787EB4, NameHash = 0x2A6BB71EAF092577)]
    public class GcNPCHabitationType : NMSTemplate
    {
		public enum NPCHabitationTypeEnum { WeaponsExpert, Farmer, Builder, Vehicles, Scientist }
		public NPCHabitationTypeEnum NPCHabitationType;
    }
}