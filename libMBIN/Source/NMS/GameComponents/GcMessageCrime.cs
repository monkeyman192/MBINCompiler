using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1CCB7BDC1ECBB02A, NameHash = 0xC64AF7F76101CD0)]
    public class GcMessageCrime : NMSTemplate
    {
		public enum CrimeEnum { AttackCreature, AttackSentinel, KillCreature, KillSentinel, MineResources, HitResources, AttackSpaceStation, AttackShip, AttackPolice,
            KillShip, KillPolice, TimedShootable }
		public CrimeEnum Crime;
        public Vector4f Position;
        public int Value;
    }
}
