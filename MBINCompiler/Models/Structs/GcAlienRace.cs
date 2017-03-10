namespace MBINCompiler.Models.Structs
{
    public class GcAlienRace : NMSTemplate
    {
        public int AlienRace;

        public string[] AlienRaceValues()
        {
            return new[] { "Traders", "Warriors", "Explorers", "Robots", "Atlas", "Diplomats", "None" };
        }
    }
}
