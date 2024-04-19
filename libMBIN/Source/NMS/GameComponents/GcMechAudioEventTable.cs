using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE8F52C64436E774, NameHash = 0xEAC7A07BBA50D64B)]
    public class GcMechAudioEventTable : NMSTemplate
    {
        /* 0x000 */ public GcMechAudioEvent JetpackLP;
        /* 0x018 */ public GcMechAudioEvent JetpackLPEnd;
        /* 0x030 */ public GcMechAudioEvent JetpackRetrigger;
        /* 0x048 */ public GcMechAudioEvent JetpackTrigger;
        /* 0x060 */ public GcMechAudioEvent JumpLanding;
        /* 0x078 */ public GcMechAudioEvent JumpLandingSkid;
        /* 0x090 */ public GcMechAudioEvent MechEnter;
        /* 0x0A8 */ public GcMechAudioEvent MechExit;
        /* 0x0C0 */ public GcMechAudioEvent StepRun;
        /* 0x0D8 */ public GcMechAudioEvent StepWalk;
        /* 0x0F0 */ public GcMechAudioEvent TitanFallLanding;
        /* 0x108 */ public GcMechAudioEvent TitanFallPoseIntro;
    }
}
