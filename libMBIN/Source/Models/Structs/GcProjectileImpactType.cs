namespace libMBIN.Models.Structs
{
    public class GcProjectileImpactType : NMSTemplate
    {
		public enum ImpactEnum { Default, Terrain, Substance, Rock, Asteroid, Shield, Creature, Robot, Freighter, Cargo, Ship, Plant, NeedsTech, Player, OtherPlayer }
		public ImpactEnum Impact;
    }
}
