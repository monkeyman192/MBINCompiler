using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x89F8948FA2B8AD2A, NameHash = 0xC652A220FFABA4FE)]
    public class GcProjectileImpactType : NMSTemplate
    {
		public enum ImpactEnum { Default, Terrain, Substance, Rock, Asteroid, Shield, Creature, Robot, Freighter, Cargo, Ship, Plant, NeedsTech, Player, OtherPlayer }
		public ImpactEnum Impact;
    }
}
