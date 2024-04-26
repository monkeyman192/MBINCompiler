using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6ED3EBB059410E8E, NameHash = 0x51E0033396BF50C5)]
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
