using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcRealityCommonFactions : NMSTemplate
    {
        public int AIFaction;
        public string[] AIFactionValues()
        {
            return new[] { "FactionA", "FactionB", "FactionC", "FactionD", "Pirate", "Police" };
        }
    }
}
