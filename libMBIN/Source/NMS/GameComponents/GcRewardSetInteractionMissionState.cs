using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9F144D702FC0DF35, NameHash = 0x6CE18BA2B414C4ED)]
    public class GcRewardSetInteractionMissionState : NMSTemplate
    {
        /* 0x0 */ public GcInteractionMissionState MissionState;
        /* 0x4 */ public GcInteractionType SetForInteractionClassInMyBuilding;
        /* 0x8 */ public bool SetForThisInteraction;
    }
}
