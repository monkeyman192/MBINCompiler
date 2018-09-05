namespace libMBIN.Models.Structs
{
    public class GcAISpaceshipRoles : NMSTemplate
    {
        public int AIShipRole;
        public string[] AIShipRoleValues()
        {
            return new[] { "Standard", "Freighter", "CapitalFreighter", "SmallFreighter", "TinyFreighter", "Frigate" };
        }
    }
}
