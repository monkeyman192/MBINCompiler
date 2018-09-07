namespace libMBIN.Models.Structs
{
    public class GcCreatureRoles : NMSTemplate
    {
		public enum CreatureRoleEnum { None, Predator, PlayerPredator, Prey, Passive, Bird, FishPrey, FishPredator, Butterfly, Robot }
		public CreatureRoleEnum CreatureRole;
    }
}
