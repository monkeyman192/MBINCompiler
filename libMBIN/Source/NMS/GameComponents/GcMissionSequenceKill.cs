using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10C, GUID = 0x50DAC8689EC4F419, NameHash = 0xF2F929BD28DDCD6B)]
    public class GcMissionSequenceKill : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
		public enum KillTargetEnum { Robots, Drones, Quads, Walkers, Predators, Creatures, Pirates, Traders, Fiends, HazardousFlora }
		public KillTargetEnum KillTarget;
        /* 0x084 */ public int AmountMin;
        /* 0x088 */ public int AmountMax;
        /* 0x08C */ public NMSString0x80 DebugText;
    }
}
