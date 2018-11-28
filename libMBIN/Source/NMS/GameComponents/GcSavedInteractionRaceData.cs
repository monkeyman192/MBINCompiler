using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1C, GUID = 0x49B6560B195F1E94)]
    public class GcSavedInteractionRaceData : NMSTemplate
    {
        [NMS( EnumType = typeof( GcAlienRace.AlienRaceEnum ) )]
        public int[] SavedRaceIndicies;
    }
}
