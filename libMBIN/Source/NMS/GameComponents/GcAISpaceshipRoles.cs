using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcAISpaceshipRoles : NMSTemplate
    {
        public int AIShipRole;
        public string[] AIShipRoleValues()
        {
            return new[] { "Standard", "Freighter", "CapitalFreighter" };
        }
    }
}
