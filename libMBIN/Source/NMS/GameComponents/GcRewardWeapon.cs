using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8065CE79959EB1B9, NameHash = 0xDF91F2B5F746FB61)]
    public class GcRewardWeapon : NMSTemplate
    {
        /* 0x0 */ public int ItemLevel;
        /* 0x4 */ public bool MarkInteractionComplete;
        /* 0x5 */ public bool UsePlanetSeed;
        /* 0x6 */ public bool ForceFixed;
        /* 0x7 */ public bool RequeueInteraction;
        /* 0x8 */ public bool ReinteractOnDecline;
        /* 0x9 */ public bool OnlyUseNextInteractionOnSuccess;
        /* 0xC */ public float SecretPoolChance;
    }
}
