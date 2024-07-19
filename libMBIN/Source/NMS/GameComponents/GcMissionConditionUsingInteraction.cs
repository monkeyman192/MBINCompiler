using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8566D655FB3655A4, NameHash = 0xA2DF8263)]
    public class GcMissionConditionUsingInteraction : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcInteractionType InteractionType;
        [NMS(Index = 1)]
        /* 0x4 */ public GcAlienRace Race;
        [NMS(Index = 2)]
        /* 0x8 */ public bool MustBeSelectedMission;
    }
}
