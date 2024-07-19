using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x96813A9CC0D51AB3, NameHash = 0x1FE5BC27)]
    public class GcSavedInteractionRaceData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x00 */ public int[] SavedRaceIndicies;
        [NMS(Index = 1, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x24 */ public bool[] HasLoopedIndicies;
    }
}
