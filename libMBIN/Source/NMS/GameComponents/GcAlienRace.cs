using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcAlienRace : NMSTemplate
    {
        public int AlienRace;

        public string[] AlienRaceValues()
        {
            return new[] { "Traders", "Warriors", "Explorers", "Robots", "Atlas", "Diplomat", "None" };
        }
    }
}
