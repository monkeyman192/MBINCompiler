using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9064A655757AF603, NameHash = 0xA8AB3ECD5F81E80C)]
    public class GcCreatureRoles : NMSTemplate
    {
		public enum CreatureRoleEnum { None, Predator, PlayerPredator, Prey, Passive, Bird, FishPrey, FishPredator, Butterfly, Robot }
		public CreatureRoleEnum CreatureRole;
    }
}
