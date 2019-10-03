using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC223EE60F633E3D8, NameHash = 0x428DC2A675E89B6D)]
    public class GcAlienPuzzleCategory : NMSTemplate
    {
        // 0x2B options
		public enum AlienPuzzleCategoryEnum { Default, GuildTraderNone, GuildTraderLow, GuildTraderMed, GuildTraderHigh, GuildTraderBest, GuildWarriorNone, GuildWarriorLow,
            GuildWarriorMed, GuildWarriorHigh, GuildWarriorBest, GuildExplorerNone, GuildExplorerLow, GuildExplorerMed, GuildExplorerHigh, GuildExplorerBest, BiomeHot, BiomeCold,
            BiomeLush, BiomeDusty, BiomeTox, BiomeRad, BiomeWeird, LocationSpaceStation, LocationShop, LocationOutpost, LocationObservatory, Walking, ExtremeWeather, ExtremeSentinels,
            WaterPlanet, FreighterCrew, FreighterCrewOwned, ShipShop, SuitShop, WeapShop, VehicleShop, MoodVeryPositive, MoodPositive, MoodNeutral, MoodNegative, MoodVeryNegative, Proc }
		public AlienPuzzleCategoryEnum AlienPuzzleCategory;
    }
}
