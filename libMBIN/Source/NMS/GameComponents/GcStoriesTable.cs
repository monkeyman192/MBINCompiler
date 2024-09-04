using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD20313E4178D678, NameHash = 0xC8295625)]
    public class GcStoriesTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x0 */ public GcStoryCategory[] Table;
    }
}
