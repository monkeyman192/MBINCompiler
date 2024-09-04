using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA2F83169536E8C9B, NameHash = 0xB01C10E3)]
    public class GcMechAudioEventTable : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x000 */ public GcMechAudioEvent JetpackLP;
        [NMS(Index = 11)]
        /* 0x018 */ public GcMechAudioEvent JetpackLPEnd;
        [NMS(Index = 9)]
        /* 0x030 */ public GcMechAudioEvent JetpackRetrigger;
        [NMS(Index = 8)]
        /* 0x048 */ public GcMechAudioEvent JetpackTrigger;
        [NMS(Index = 5)]
        /* 0x060 */ public GcMechAudioEvent JumpLanding;
        [NMS(Index = 6)]
        /* 0x078 */ public GcMechAudioEvent JumpLandingSkid;
        [NMS(Index = 0)]
        /* 0x090 */ public GcMechAudioEvent MechEnter;
        [NMS(Index = 1)]
        /* 0x0A8 */ public GcMechAudioEvent MechExit;
        [NMS(Index = 3)]
        /* 0x0C0 */ public GcMechAudioEvent StepRun;
        [NMS(Index = 2)]
        /* 0x0D8 */ public GcMechAudioEvent StepWalk;
        [NMS(Index = 4)]
        /* 0x0F0 */ public GcMechAudioEvent TitanFallLanding;
        [NMS(Index = 7)]
        /* 0x108 */ public GcMechAudioEvent TitanFallPoseIntro;
    }
}
