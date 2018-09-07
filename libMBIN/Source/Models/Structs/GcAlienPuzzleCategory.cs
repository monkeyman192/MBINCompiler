namespace libMBIN.Models.Structs
{
    public class GcAlienPuzzleCategory : NMSTemplate
    {
		public enum AlienPuzzleCategoryEnum { Default, GuildTraderNone, GuildTraderLow, GuildTraderMed, GuildTraderHigh, GuildTraderBest, GuildWarriorNone, GuildWarriorLow,
                                              GuildWarriorMed, GuildWarriorHigh, GuildWarriorBest, GuildExplorerNone, GuildExplorerLow, GuildExplorerMed, GuildExplorerHigh,
                                              GuildExplorerBest }
		public AlienPuzzleCategoryEnum AlienPuzzleCategory;
    }
}
