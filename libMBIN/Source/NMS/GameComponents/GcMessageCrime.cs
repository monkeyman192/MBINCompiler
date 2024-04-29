namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3475FBDFCC71DF04, NameHash = 0xC64AF7F76101CD0)]
    public class GcMessageCrime : NMSTemplate
    {
        [NMS(Index = 1)]
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
        [NMS(Index = 0)]
        /* 0x10 */ public CrimeEnum Crime;
        [NMS(Index = 2)]
        /* 0x14 */ public GcNodeID Criminal;
        [NMS(Index = 4)]
        /* 0x18 */ public int Value;
        [NMS(Index = 3)]
        /* 0x1C */ public GcNodeID Victim;
    }
}
