namespace libMBIN.Models.Structs
{
    public class GcMissionSequenceKill : NMSTemplate      // size: 0x10C
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
		public enum KillTargetEnum { Robots, Drones, Quads, Walkers, Predators, Creatures, Pirates, Traders, Fiends, FeedCreatures }
		public KillTargetEnum KillTarget;
        /* 0x084 */ public int AmountMin;
        /* 0x088 */ public int AmountMax;
        [NMS(Size = 0x80)]
        /* 0x08C */ public string DebugText;
    }
}
