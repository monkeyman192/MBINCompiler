namespace libMBIN.Models.Structs
{
    public class GcMissionSequenceKill : NMSTemplate      // size: 0x10C
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public int KillTarget;
        public string[] KillTargetValues()
        {
            return new[] { "Robots", "Drones", "Quads", "Walkers", "Predators", "Creatures", "Pirates", "Traders", "Fiends", "FeedCreatures"};
        }
        /* 0x084 */ public int AmountMin;
        /* 0x088 */ public int AmountMax;
        [NMS(Size = 0x80)]
        /* 0x08C */ public string DebugText;
    }
}
