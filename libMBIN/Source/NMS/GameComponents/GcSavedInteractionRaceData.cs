using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x49B6560B195F1E94, NameHash = 0x9B192CD525C0A892)]
    public class GcSavedInteractionRaceData : NMSTemplate
    {
        [NMS(Size = 8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        public int[] SavedRaceIndicies;
    }
}
