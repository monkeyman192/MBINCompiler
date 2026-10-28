using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBC9F0D4CEF3F90F9, NameHash = 0x4C8D8D)]
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
