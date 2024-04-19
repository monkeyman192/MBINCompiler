namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6C85ED98FDA49EF4, NameHash = 0xC64AF7F76101CD0)]
    public class GcMessageCrime : NMSTemplate
    {
        /* 0x00 */ public Vector3f Position;
        // size: 0xD
        public enum CrimeEnum : uint {
            AttackCreature,
            AttackSentinel,
            AttackSentinelLaser,
            KillCreature,
            KillSentinel,
            MineResources,
            HitResources,
            AttackSpaceStation,
            AttackShip,
            AttackPolice,
            KillShip,
            KillPolice,
            TimedShootable,
        }
        /* 0x10 */ public CrimeEnum Crime;
        /* 0x14 */ public GcNodeID Criminal;
        /* 0x18 */ public int Value;
        /* 0x1C */ public GcNodeID Victim;
    }
}
