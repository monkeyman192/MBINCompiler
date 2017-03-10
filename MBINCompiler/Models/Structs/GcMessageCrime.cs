namespace MBINCompiler.Models.Structs
{
    public class GcMessageCrime : NMSTemplate
    {
        public int Crime;
        public string[] CrimeValues()
        {
            return new[]
            {
                "AttackCreature", "AttackSentinel", "KillCreature", "KillSentinel", "MineResources", "HitResources",
                "AttackSpaceStation", "AttackShip", "AttackPolice", "KillShip", "KillPolice", "TimedShootable"
            };
        }
        public Vector4f Position;
        public int Value;
    }
}
