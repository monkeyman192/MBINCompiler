using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA02C9116F89F18EE, NameHash = 0xB4578AF4AEBD0B11)]
    public class GcNPCWordReactionTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x0 */ public GcNPCWordReactionCategory[] Races;
    }
}
