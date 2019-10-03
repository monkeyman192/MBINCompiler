using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x2CCEA81A61F5A8D4, NameHash = 0x4533D19670B0A519)]
    public class GcAISpaceshipRoles : NMSTemplate
    {
		public enum AIShipRoleEnum { Standard, Freighter, CapitalFreighter, SmallFreighter, TinyFreighter, Frigate }
		public AIShipRoleEnum AIShipRole;
    }
}
