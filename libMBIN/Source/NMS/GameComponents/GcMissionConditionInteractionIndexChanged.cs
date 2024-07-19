using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x893B5ACDF4AD3876, NameHash = 0x4AABEBAF)]
    public class GcMissionConditionInteractionIndexChanged : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcInteractionType InteractionType;
        [NMS(Index = 1)]
        /* 0x4 */ public GcAlienRace Race;
    }
}
