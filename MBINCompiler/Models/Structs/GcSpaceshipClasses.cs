namespace MBINCompiler.Models.Structs
{
    public class GcSpaceshipClasses : NMSTemplate
    {
        public int ShipClass;
        public string[] ShipClassValues()
        {
            return new[] { "Freighter", "Dropship", "Fighter", "Scientific", "Shuttle", "PlayerFreighter" };
        }
    }
}
