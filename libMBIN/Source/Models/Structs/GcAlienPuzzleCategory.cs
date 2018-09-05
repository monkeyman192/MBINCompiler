namespace libMBIN.Models.Structs
{
    public class GcAlienPuzzleCategory : NMSTemplate
    {
        public int AlienPuzzleCategory;
        public string[] AlienPuzzleCategoryValues()
        {
            return new[] { "Default", "GuildTraderNone", "GuildTraderLow", "GuildTraderMed", "GuildTraderHigh", "GuildTraderBest",
                           "GuildWarriorNone", "GuildWarriorLow", "GuildWarriorMed", "GuildWarriorHigh", "GuildWarriorBest",
                           "GuildExplorerNone", "GuildExplorerLow", "GuildExplorerMed", "GuildExplorerHigh", "GuildExplorerBest"};
        }
    }
}
