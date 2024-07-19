using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEAF4F5B4AEFB9644, NameHash = 0x8998F482)]
    public class GcNPCWordReactionTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x0 */ public GcNPCWordReactionCategory[] Races;
    }
}
