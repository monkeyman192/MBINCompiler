using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3A2B518940A95910, NameHash = 0x428DC2A675E89B6D)]
    public class GcAlienPuzzleCategory : NMSTemplate
    {
        // size: 0x35
        public enum AlienPuzzleCategoryEnum { Default, GuildTraderNone, GuildTraderLow, GuildTraderMed, GuildTraderHigh,
            GuildTraderBest, GuildWarriorNone, GuildWarriorLow, GuildWarriorMed,
            GuildWarriorHigh, GuildWarriorBest, GuildExplorerNone, GuildExplorerLow,
            GuildExplorerMed, GuildExplorerHigh, GuildExplorerBest, BiomeHot,
            BiomeCold, BiomeLush, BiomeDusty, BiomeTox, BiomeRad, BiomeWeird, LocationSpaceStation,
            LocationShop, LocationOutpost, LocationObservatory,
            Walking, ExtremeWeather, ExtremeSentinels, WaterPlanet, FreighterCrew,
            FreighterCrewOwned, ShipShop, SuitShop, WeapShop, VehicleShop, MoodVeryPositive,
            MoodPositive, MoodNeutral, MoodNegative, MoodVeryNegative,
            Proc, FirstAbandonedFreighter, StandardAbandonedFreighter, BiomeSwamp,
            BiomeLava, AbandonedSystem, InhabitedSystem, SettlementOwned, SettlementNotOwned,
            PirateStation, StandardPilot
        }
        /* 0x0 */ public AlienPuzzleCategoryEnum AlienPuzzleCategory;
    }
}
