using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3E7DA33CE8142243, NameHash = 0xA8AB3ECD5F81E80C)]
    public class GcCreatureRoles : NMSTemplate
    {
        // size: 0xB
		public enum CreatureRoleEnum { None, Predator, PlayerPredator, Prey, Passive, Bird, FishPrey, FishPredator, Butterfly, Robot, Pet }
		public CreatureRoleEnum CreatureRole;
    }
}