using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x659A033DCEA9969E, NameHash = 0x6CE18BA2B414C4ED)]
    public class GcRewardSetInteractionMissionState : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcInteractionMissionState MissionState;
        [NMS(Index = 2)]
        /* 0x4 */ public GcInteractionType SetForInteractionClassInMyBuilding;
        [NMS(Index = 1)]
        /* 0x8 */ public bool SetForThisInteraction;
    }
}
