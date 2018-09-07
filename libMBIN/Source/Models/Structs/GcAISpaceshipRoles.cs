namespace libMBIN.Models.Structs
{
    public class GcAISpaceshipRoles : NMSTemplate
    {
		public enum AIShipRoleEnum { Standard, Freighter, CapitalFreighter, SmallFreighter, TinyFreighter, Frigate }
		public AIShipRoleEnum AIShipRole;
    }
}
