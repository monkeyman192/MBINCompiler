namespace libMBIN.Models.Structs
{
    public class GcMessageCrime : NMSTemplate
    {
		public enum CrimeEnum { AttackCreature, AttackSentinel, KillCreature, KillSentinel, MineResources, HitResources, AttackSpaceStation, AttackShip, AttackPolice,
            KillShip, KillPolice, TimedShootable }
		public CrimeEnum Crime;
        public Vector4f Position;
        public int Value;
    }
}
