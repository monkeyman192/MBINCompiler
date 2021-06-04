using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x90F0DF33F62406AA, NameHash = 0x428DC2A675E89B6D)]
    public class GcAlienPuzzleCategory : NMSTemplate
    {
        // size: 0x31
        public enum AlienPuzzleCategoryEnum {
            Default, GuildTraderNone, GuildTraderLow, GuildTraderMed, GuildTraderHigh, GuildTraderBest, GuildWarriorNone, GuildWarriorLow, GuildWarriorMed, GuildWarriorHigh,
            GuildWarriorBest, GuildExplorerNone, GuildExplorerLow, GuildExplorerMed, GuildExplorerHigh, GuildExplorerBest, BiomeHot, BiomeCold, BiomeLush, BiomeDusty,
            BiomeTox, BiomeRad, BiomeWeird, LocationSpaceStation, LocationShop, LocationOutpost, LocationObservatory, Walking, ExtremeWeather, ExtremeSentinels,
            WaterPlanet, FreighterCrew, FreighterCrewOwned, ShipShop, SuitShop, WeapShop, VehicleShop, MoodVeryPositive, MoodPositive, MoodNeutral,
            MoodNegative, MoodVeryNegative, Proc, FirstAbandonedFreighter, StandardAbandonedFreighter, BiomeSwamp, BiomeLava, AbandonedSystem, InhabitedSystem
        }
        public AlienPuzzleCategoryEnum AlienPuzzleCategory;
    }
}